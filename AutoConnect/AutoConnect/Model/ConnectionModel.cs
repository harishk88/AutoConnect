﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoConnect.Converters;

namespace AutoConnect.Model
{
    public class ConnectionModel
    {
        private ObservableCollection<ConnectionSetting> _beamToBeamWebColl;
        public ObservableCollection<ConnectionSetting> BeamToBeamWebColl
        {
            get
            {
                return this._beamToBeamWebColl;
            }
            set
            {
                this._beamToBeamWebColl = value;
            }
        }

        private ObservableCollection<ConnectionSetting> _beamToColumnWebColl;
        public ObservableCollection<ConnectionSetting> BeamToColumnWebColl
        {
            get
            {
                return this._beamToColumnWebColl;
            }
            set
            {
                this._beamToColumnWebColl = value;
            }
        }

        private ObservableCollection<ConnectionSetting> _beamToColumnFlangeColl;
        public ObservableCollection<ConnectionSetting> BeamToColumnFlangeColl
        {
            get
            {
                return this._beamToColumnFlangeColl;
            }
            set
            {
                this._beamToColumnFlangeColl = value;
            }
        }
    }

    public class ConnectionSetting
    {
        public bool IsChecked { get; set; }
        public int PrimaryId { get; set; }
        public int SecondaryId { get; set; }
        public int[] SecondaryIds { get; set; }
        public object PrimaryObject { get; set; }
        public bool IsSingleConnection { get; set; }
        public object SecondaryObject { get; set; }
        public ArrayList SecondaryObjects { get; set; }
        public string ConnectionType { get; set; }
        public string Component { get; set; }
        public string BoltWeldOrientation { get; set; }
        public string AngleType { get; set; }


        public string ConnectingObjects { get; set; }
    }

    //public class ConnectionSetting
    //{
    //    public bool IsChecked { get; set; }
    //    public int PrimaryId { get; set; }
    //    public int SecondaryId { get; set; }
    //    public int[] SecondaryIds { get; set; }
    //    public object PrimaryObject { get; set; }
    //    public bool IsSingleConnection { get; set; }
    //    public object SecondaryObject { get; set; }
    //    public ArrayList SecondaryObjects { get; set; }
    //    public string ConnectionType { get; set; }
    //    public ComponentType Component { get; set; }
    //    public BoltWeldOrientation BoltWeldOrientation { get; set; }
    //    public AngleTypes AngleType { get; set; }


    //    public string ConnectingObjects { get; set; }
    //}
}
