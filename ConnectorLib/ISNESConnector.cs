/*
 * Copyright 2018 Equilateral IT
 *
 * ConnectorLib is free software: you can redistribute it and/or modify
 * it under the terms of the GNU Lesser General Public License as published by
 * the Free Software Foundation, either version 3 of the License, or
 * (at your option) any later version.
 *
 * ConnectorLib is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU Lesser General Public License for more details.
 *
 * You should have received a copy of the GNU Lesser General Public License
 * along with ConnectorLib.  If not, see <http://www.gnu.org/licenses/>.
 */

namespace ConnectorLib
{
    /// <summary>
    /// Provides an interface for SNES connector objects to implement.
    /// </summary>
    public interface ISNESConnector : IGameConnector
    {
        /// <summary>
        /// Writes a byte to the SNES.
        /// </summary>
        /// <param name="address">The 24-bit SNES bus address.</param>
        /// <param name="value">The value to be written.</param>
        /// <returns>True if the write was successful, otherwise false.</returns>
        bool WriteByte(uint address, byte value);

        /// <summary>
        /// Writes an usigned short to the SNES.
        /// </summary>
        /// <param name="address">The 24-bit SNES bus address.</param>
        /// <param name="value">The value to be written.</param>
        /// <returns>True if the write was successful, otherwise false.</returns>
        bool WriteWord(uint address, ushort value);

        /// <summary>
        /// Reads a byte from the SNES.
        /// </summary>
        /// <param name="address">The 24-bit SNES bus address.</param>
        /// <returns>The byte to be read if the read was successful, otherwise null.</returns>
        byte? ReadByte(uint address);

        /// <summary>
        /// Reads an unsigned short from the SNES.
        /// </summary>
        /// <param name="address">The 24-bit SNES bus address.</param>
        /// <returns>The byte to be read if the read was successful, otherwise null.</returns>
        ushort? ReadWord(uint address);

        /// <summary>
        /// Sets a bitmask at the specified address.
        /// </summary>
        /// <param name="address">The 24-bit SNES bus address.</param>
        /// <param name="value">The bit mask.</param>
        /// <returns>True if the write was successful, otheriwse false.</returns>
        bool SetBit(uint address, byte value);

        /// <summary>
        /// Unsets a bitmask at the specified address.
        /// </summary>
        /// <param name="address">The 24-bit SNES bus address.</param>
        /// <param name="value">The bit mask.</param>
        /// <returns>True if the write was successful, otheriwse false.</returns>
        bool UnsetBit(uint address, byte value);
    }
}