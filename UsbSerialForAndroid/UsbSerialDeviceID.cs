/* Copyright 2011-2013 Google Inc.
 * Copyright 2013 mike wakerly <opensource@hoho.com>
 * Copyright 2015 Yasuyuki Hamada <yasuyuki_hamada@agri-info-design.com>
 *
 * This library is free software; you can redistribute it and/or
 * modify it under the terms of the GNU Lesser General Public
 * License as published by the Free Software Foundation; either
 * version 2.1 of the License, or (at your option) any later version.
 *
 * This library is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU
 * Lesser General Public License for more details.
 *
 * You should have received a copy of the GNU Lesser General Public
 * License along with this library; if not, write to the Free Software
 * Foundation, Inc., 51 Franklin Street, Fifth Floor, Boston, MA  02110-1301,
 * USA.
 *
 * Project home page: https://github.com/ysykhmd/usb-serial-for-xamarin-android
 * 
 * This project is based on usb-serial-for-android and ported for Xamarin.Android.
 * Original project home page: https://github.com/mik3y/usb-serial-for-android
 */

namespace Aid.UsbSerial
{
	public struct UsbSerialDeviceID
	{
		public readonly int VendorID;
		public readonly int ProductID;

		public UsbSerialDeviceID(int vendorId, int productId)
		{
			VendorID = vendorId;
			ProductID = productId;
		}

        public override bool Equals(object obj)
        {
            if (!(obj is UsbSerialDeviceID))
            {
                return false;
            }

            UsbSerialDeviceID id = (UsbSerialDeviceID)obj;
            if ((VendorID == id.VendorID) && (ProductID == id.ProductID))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override int GetHashCode()
        {
            return VendorID ^ ProductID;
        }
	}
}
