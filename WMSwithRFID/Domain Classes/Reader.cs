using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using System.Threading;
using System.Runtime.InteropServices;
using MySql.Data.MySqlClient;

namespace WMSwithRFID.Domain_Classes
{
    public class Reader
    {

        //state for connection
        public bool connectionState = false;

        public IntPtr pHandle = IntPtr.Zero;

        /// <summary>
        /// Read Tag Thread
        /// </summary>
        Thread readThread = null;

        /// <summary>
        /// Read Tag Status
        /// </summary>
        bool readTagStatus = false;


        /// <summary>
        /// Tag Information Buffer
        /// </summary>
        Antenna revMsgLine = new Antenna();

        /// <summary>
        /// Operating type
        /// </summary>
        int SAAT_CODE_TYPE = 0;

        /// <summary>
        /// Antenna No.
        /// </summary>
        byte sAntenna = 0;

        /// <summary>
        /// Read Tag Type
        /// </summary>
        int SAAT_READ_TYPE = 1;


        public Reader()
        {
            System.Windows.Forms.Control.CheckForIllegalCrossThreadCalls = false;
            //loadReadRFID();           
        }

        /// <summary>
        /// Initializing
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>


        /// <summary>
        /// Open Connect
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 
        public bool openConnection(string comPort)
        {

            bool initialize = false;

            initialize = RFIDAPI.SAAT_USBInit(out pHandle, 0x00, comPort, 19200);

            if (!initialize)
            {
                return false;
            }


            // 2.Connect
            connectionState = RFIDAPI.SAAT_Open(pHandle);
            if (!connectionState)
            {
                return false;
            }

            else
            {
                return true;
            }
        }

        private bool CloseConn()
        {
            if (pHandle == IntPtr.Zero)
            {
                return true;
            }

            readTagStatus = false;
            bool bRet = RFIDAPI.SAAT_Close(pHandle);
            if (bRet)
            {
                pHandle = IntPtr.Zero;
            }
            return bRet;
        }
        /// <sumCmary>
        /// Close connection
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public bool CloseConnection()
        {
            connectionState = !CloseConn();
            if (connectionState)
            {
                return false;
            }

            return true;
        }

        /// <summary>
        /// Start Reading
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 

        public bool accessDatabase { get; set; }

        public bool StartReading()
        {
            // Setup Timer to Update the received information
            if (readThread != null)
            {
                if (readThread.IsAlive)
                {
                    readThread.Abort();
                    readThread.Join();
                }
            }


            if (!sendReadTagCommand())
            {
                return false;

            }

            readTagStatus = true;



            // revMsgLine.ClearAntennaDetails();

            readThread = new Thread(new ThreadStart(receivedTagInformationThread));
            readThread.Start();
            return true;
        }



        /// <summary>
        /// Thread of Receive tag information 
        /// </summary>
        private void receivedTagInformationThread()
        {
            int receivedTagResult = 0;

            AntennaDetails receivedAntennaDetails = new AntennaDetails();

            while (readTagStatus)
            {
                receivedTagResult = receivedTagInfo(ref receivedAntennaDetails);
                if (receivedTagResult == 1)//Get tag information
                {
                    revMsgLine.AddAntennaDetails(receivedAntennaDetails);
                }
            }
        }

        /// <summary>
        /// Send read-tag command function
        /// </summary>
        /// <returns></returns>
        public bool sendReadTagCommand()
        {
            byte SAAT_SCAN_TRIES = 3;

            switch (SAAT_CODE_TYPE)
            {
                case 0://Read EPC Code
                    return RFIDAPI.SAAT_6CReadEPCCode(pHandle, sAntenna, (byte)SAAT_READ_TYPE, SAAT_SCAN_TRIES);
                case 1://Read TID Code
                    return RFIDAPI.SAAT_6CReadTIDCode(pHandle, sAntenna, (byte)SAAT_READ_TYPE, SAAT_SCAN_TRIES);
                case 2://Read UID Code
                    return RFIDAPI.SAAT_6BReadUIDCode(pHandle, sAntenna, (byte)SAAT_READ_TYPE);
            }
            return false;
        }

        /// <summary>
        /// Receive tag information function
        /// </summary>
        /// <param name="receivedAntennaDetails">Struct for storing tag information</param>
        /// <returns></returns>
        public int receivedTagInfo(ref AntennaDetails revMsg)
        {
            byte sLength = 255;     // 
            string sData = "";
            byte[] btData = new byte[255];
            int bResult = 0;

            try
            {
                switch (SAAT_CODE_TYPE)
                {
                    case 0:
                        bResult = RFIDAPI.SAAT_6CRevEPCMsg(pHandle, out sAntenna, btData, out sLength);
                        break;
                    case 1:
                        bResult = RFIDAPI.SAAT_6CRevTIDMsg(pHandle, out sAntenna, btData, out sLength);
                        break;
                    case 2:
                        bResult = RFIDAPI.SAAT_6BRevUIDMsg(pHandle, out sAntenna, btData, out sLength);
                        break;
                }
            }
            catch
            {

            }

            if (bResult == 1 && sLength != 255)
            {
                //MessageBox.Show("" + sAntenna);
                revMsg.antennaNo = (int)sAntenna;
                for (byte bytei = 0; bytei < sLength; bytei++)
                    sData += btData[bytei].ToString("X2");
                revMsg.epcCode = sData;
                revMsg.nRepeatTime = 1;
                // MessageBox.Show("" + revMsg.nRepeatTime);
            }

            if (revMsg.antennaNo == 1 && revMsg.nRepeatTime == 1)
            {
                revMsg.nRepeatTime = revMsg.nRepeatTime - 1;

                WMScontext wms = new WMScontext();
              
                //add epc to DB
                var epcCount = (from epc in wms.FinishedProducts where epc.EPC == sData select epc).Count();
                if (epcCount == 0)
                {
                    FinishedProduct fp1 = new FinishedProduct
                    {

                        DateManufactured = DateTime.Now,
                        Status = (Status)Enum.Parse(typeof(Status), "OntheMove"),
                        EPC = sData,
                      
                    };

                    wms.FinishedProducts.Add(fp1);
                    wms.SaveChanges();
                }
            }
            if (revMsg.antennaNo == 2 && revMsg.nRepeatTime == 1)
            {
                revMsg.nRepeatTime = revMsg.nRepeatTime - 1;
                WMScontext wms2 = new WMScontext();
                var epcCount = (from epc in wms2.FinishedProducts where epc.EPC == sData select epc).Count();
                if (epcCount == 0)
                {
                    FinishedProduct fp = new FinishedProduct
                    {

                        DateManufactured = DateTime.Now,
                        Status = (Status)Enum.Parse(typeof(Status), "Stored"),
                        EPC = sData
                    };

                    wms2.FinishedProducts.Add(fp);
                    wms2.SaveChanges();
                }
            }
            return bResult;
        }

        /// <summary>
        /// Stop Read Tag
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /* public bool StopReading()
         {


             //Terminate Thread
             if (readThread.IsAlive)
             {
                 readThread.Abort();
                 readThread.Join();
             }

             // Stop Read Tag
             if (RFIDAPI.SAAT_PowerOff(pHandle))
             {
                 return true;
             }
             else
             {
                 return false;
             }

             // Clear
             readTagStatus = false;
         }
         */


        /// <summary>
        /// Exit The System
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>


        /// <summary>
        /// 
        /// </summary>
        //private void Exit()
        //{
        //    try
        //    {
        //        if (readThread.IsAlive) readThread.Abort();
        //    }
        //    catch { }

        //    System.Diagnostics.Process[] LocalPro = System.Diagnostics.Process.GetProcessesByName("ProcessName");
        //    if (LocalPro.Length > 0)
        //    {
        //        foreach (System.Diagnostics.Process a in LocalPro) { a.Kill(); }
        //    }
        //    Application.Exit();

        //}

    }
}
