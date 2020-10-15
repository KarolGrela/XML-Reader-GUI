﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XMLReaderClassLibrary.DataStorage
{
    public class FileInfo
    {

        #region fields and properties
        /*
         * fields
         */
        private string version;
        private string production_area;
        private string machine_type;
        private string status;
        private string timestamp;
        private string SW;
        private string user;
        private string environment_version;
        private string machine_type_id;
        private string custom_prop_1_name;
        private string custom_prop_2_name;

        /*
         * properites
         * (getters and setters)
         */
        public string Version { get => version; set => version = value; }
        public string Production_area { get => production_area; set => production_area = value; }
        public string Machine_type { get => machine_type; set => machine_type = value; }
        public string Status { get => status; set => status = value; }
        public string Timestamp { get => timestamp; set => timestamp = value; }
        public string SW1 { get => SW; set => SW = value; }
        public string User { get => user; set => user = value; }
        public string Environment_version { get => environment_version; set => environment_version = value; }
        public string Machine_type_id { get => machine_type_id; set => machine_type_id = value; }
        public string Custom_prop_1_name { get => custom_prop_1_name; set => custom_prop_1_name = value; }
        public string Custom_prop_2_name { get => custom_prop_2_name; set => custom_prop_2_name = value; }
        #endregion

        #region Methods
        // prepare string of data to display 
        public string DisplayData()
        {
            string DataString = ""; // initailize

            DataString = "File Info\n";
            DataString += $"    Version: {Version}\n";
            DataString += $"    Production area: {Production_area}\n";
            DataString += $"    Machine type: {Machine_type}\n";
            DataString += $"    Status: {Status}\n";
            DataString += $"    Timestamp: {Timestamp}\n";
            DataString += $"    SW: {SW1}\n";
            DataString += $"    User: {User}\n";
            DataString += $"    Environment version: {Environment_version}\n";
            DataString += $"    Machine type ID: {Machine_type_id}\n";
            DataString += $"    Custom prop 1 name: {Custom_prop_1_name}\n";
            DataString += $"    Custom prop 2 name: {Custom_prop_2_name}\n";
            DataString += "/File Info\n";

            return DataString;
        }
        #endregion

    }

}
