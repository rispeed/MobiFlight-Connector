﻿using MobiFlight.CustomDevices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace MobiFlight.UI.Panels.Settings.Device
{
    public partial class MFCustomDevicePanel : UserControl
    {

        private MobiFlight.Config.CustomDevice device;
        private bool initialized = false;
        
        public event EventHandler Changed;

        public MFCustomDevicePanel()
        {
            InitializeComponent();
            groupBox1.Controls.Clear();
        }

        public MFCustomDevicePanel(MobiFlight.Config.CustomDevice device, List<MobiFlightPin> Pins): this()
        {
            this.device = device;

            var deviceDefinition = CustomDeviceDefinitions.GetDeviceByType(device.CustomType);
            var PinsI2C = new List<MobiFlightPin>();
            var labels = deviceDefinition.Config.Pins;

            if (deviceDefinition.Config.isI2C)
            {
                labels = new List<string>() { "Address" };
                deviceDefinition.Config.Pins.ForEach(p => PinsI2C.Add(new MobiFlightPin() { 
                    Name = p, 
                    isI2C = true, 
                    Pin = byte.Parse(p.Replace("0x",""), System.Globalization.NumberStyles.AllowHexSpecifier) 
                }));                
            }

            var i = 0;
            foreach (var pin in labels)
            {
                if (i == deviceDefinition.Config.Pins.Count) break;

                var currentComboBox = new MFCustomDevicePanelPin(
                    pin, 
                    deviceDefinition.Config.isI2C ? PinsI2C : Pins,
                    device.ConfiguredPins[i]
                );
                currentComboBox.Changed += value_Changed;
                currentComboBox.Dock = DockStyle.Bottom;
                groupBox1.Controls.Add(currentComboBox);
                i++;
            }

            textBox1.Text = device.Name;
            initialized = true;
        }

        private void value_Changed(object sender, EventArgs e)
        {
            if (!initialized) return;

            setValues();
            if (Changed != null)
                Changed(device, new EventArgs());
        }

        private void setValues()
        {   
            for(var i=0; i<device.ConfiguredPins.Count; i++)
            {
                device.ConfiguredPins[i] = (groupBox1.Controls[i] as MFCustomDevicePanelPin).SelectedPin().ToString();
            }
            
            device.Name = textBox1.Text;
        }
    }
}
