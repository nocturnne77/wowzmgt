﻿/*
This file is part of LazyBot - Copyright (C) 2011 Arutha

    LazyBot is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.

    LazyBot is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with LazyBot.  If not, see <http://www.gnu.org/licenses/>.
*/
#region

using System.Reflection;

#endregion

namespace LazyLib.Wow
{
    [Obfuscation(Feature = "renaming", ApplyToMembers = true)]
    public class PublicPointers
    {
        #region Globals enum

        /// <summary>
        ///   4.3
        /// </summary>
        public enum Globals
        {
            PlayerName = 0x9BD070,//   4.3.2
        }

        #endregion

        #region InGame enum

        /// <summary>
        ///   4.3
        /// </summary>
        public enum InGame
        {
            InGame = 0xAD5C76,//   4.3.2
        }

        #endregion
    }

    internal class Pointers
    {
        #region ActionBar enum

        /// <summary>
        ///   4.3
        /// </summary>
        public enum ActionBar
        {
            ActionBarFirstSlot = 0xB42AC8, //   4.3.2
            ActionBarBonus = 0xB42D0C, // 4.3.2
        }

        #endregion

        #region AutoLoot enum

        /// <summary>
        ///   4.3
        /// </summary>
        public enum AutoLoot
        {
            Pointer = 0xAD5E8C,//   4.3.2
            Offset = 0x30,// not sure updated
        }

        #endregion

        #region CgUnitCGetCreatureRank enum

        /// <summary>
        ///   4.3
        /// </summary>
        public enum CgUnitCGetCreatureRank
        {
            Offset1 = 0x91C,
            Offset2 = 0x1C,
        }

        #endregion

        #region CgUnitCGetCreatureType enum

        /// <summary>
        ///   4.3
        /// </summary>
        public enum CgUnitCGetCreatureType
        {
            Offset1 = 0x91C,
            Offset2 = 0x14,
        }

        #endregion

        #region CgWorldFrameGetActiveCamera enum

        /// <summary>
        ///   4.3
        /// </summary>
        public enum CgWorldFrameGetActiveCamera
        {
            CameraPointer = 0xAD6258, // 4.3.2
            CameraOffset = 0x80D0,
            CameraX = 0x8,
            CameraY = 0xC,
            CameraZ = 0x10,
            CameraMatrix = 0x14,
        }

        #endregion

        /// <summary>
        ///   4.3
        /// </summary>
        public enum Quests
        {
            ActiveQuests = 0x274,
            SelectedQuestId = 0xB436F0,
            TitleText = 0xB434D0,
            GossipQuests = 0xB70F08,
            GossipQuestNext = 0x214,
        }

        #region ClickToMove enum

        /// <summary>
        ///   4.3
        /// </summary>
        public enum ClickToMove
        {
            Pointer = 0xAD5E6C,// 4.3.2
            Offset = 0x30,
        }

        #endregion

        #region IsFlying enum

        /// <summary>
        ///   4.3
        /// </summary>
        public enum IsFlying
        {
            // Reversed from Lua_IsFlying
            Pointer = 0x100,
            Offset = 0x38,
            Mask = 0x1000000
        }

        #endregion

        #region Nested type: AutoAttack

        /// <summary>
        ///   4.3
        /// </summary>
        internal enum AutoAttack
        {
            AutoAttackFlag = 0x9E8,
            AutoAttackMask = 0x9EC,
        }

        #endregion

        #region Nested type: CastingInfo

        /// <summary>
        ///   4.3
        /// </summary>
        internal enum CastingInfo
        {
            IsCasting = 0xA34,// not update
            ChanneledCasting = 0xA48,// not update
        }

        #endregion

        #region Nested type: Chat

        /// <summary>
        ///   4.3
        /// </summary>
        internal enum Chat : uint
        {
            ChatStart = 0xAD79B8 + 0x3C,//   4.3.2
            OffsetToNextMsg = 0x17C0,
        }

        #endregion

        #region BlueChat
        /// <summary>
        ///   4.2  - Not updated
        /// </summary>
        internal enum Messages
        {
            EventMessage = 0xA98068//   not update
        }

        #endregion

        #region Nested type: ComboPoints

        /// <summary>
        ///   4.3
        /// </summary>
        internal enum ComboPoints
        {
            ComboPoints = 0xAD5D41,//   4.3.2
        }

        #endregion

        #region Nested type: Container

        /// <summary>
        ///   4.3
        /// </summary>
        internal enum Container
        {
            EquippedBagGUID = 0xB4C620,//   4.3.2
        }

        #endregion

        #region Nested type: Globals

        /// <summary>
        ///   4.3
        /// </summary>
        internal enum Globals
        {
            RedMessage = 0xAD5078,// 4.3.2
            MouseOverGUID = 0xAD5C88,// 4.3.2
            LootWindow = 0xB43A70, // 4.3.2
            IsBobbing = 0xD4,
            ArchFacing = 0x1c8,
            ChatboxIsOpen = 0xAC5628,// 4.3.2
            CursorType = 0x93BAA0, // 4.3.2
        }

        #endregion

        #region Nested type: Items

        /// <summary>
        ///   4.3
        /// </summary>
        internal enum Items : uint
        {
            Offset = 0x996F38, //4.3.2
        }

        #endregion

        #region Nested type: KeyBinding

        /// <summary>
        ///   4.3
        /// </summary>
        internal enum KeyBinding
        {
            NumKeyBindings = 0xB326EC,//  4.3.2
            First = 0xC8,// not sure update
            Next = 0xC0,// not sure update
            Key = 0x14,// not sure update
            Command = 0x28,// not sure update
        }

        #endregion

        #region Nested type: ObjectManager

        /// <summary>
        ///   4.3
        /// </summary>
        internal enum ObjectManager
        {
            CurMgrPointer = 0x9BD030,// 4.3.2
            CurMgrOffset = 0x463C,
            NextObject = 0x3C,
            FirstObject = 0xC0,
            LocalGUID = 0xC8
        }

        #endregion

        #region Nested type: Reaction

        /// <summary>
        ///   4.3
        /// </summary>
        internal enum Reaction : uint
        {
            FactionStartIndex = 0x99796C,// 4.3.2
            FactionPointer = FactionStartIndex + 0xC,// 4.3.2
            FactionTotal = FactionStartIndex - 0x4,// 4.3.2
            HostileOffset1 = 0x14,// 4.3.2
            HostileOffset2 = 0x0C,// 4.3.2
            FriendlyOffset1 = 0x10,// 4.3.2
            FriendlyOffset2 = 0x0C,// 4.3.2
        }

        #endregion

        #region Nested type: Runes

        /// <summary>
        ///   4.3
        /// </summary>
        internal enum Runes
        {
            RunesOffset = 0xB348A0, //4.3.2
        }

        #endregion

        #region Nested type: ShapeshiftForm

        /// <summary>
        ///   4.3
        /// </summary>
        internal enum ShapeshiftForm
        {
            BaseAddressOffset1 = 0xF8,// not update
            BaseAddressOffset2 = 0x1B7,// not update
        }

        #endregion

        #region Nested type: SpellCooldown

        /// <summary>
        ///   4.3
        /// </summary>
        internal enum SpellCooldown : uint
        {
            CooldPown = 0xACBF64,//4.3.2
        }

        #endregion

        #region Nested type: Swimming

        /// <summary>
        ///   4.3
        /// </summary>
        internal enum Swimming
        {
            Pointer = 0x100,
            Offset = 0x38,
            Mask = 0x100000,
        }

        #endregion

        #region Nested type: UnitAuras

        /// <summary>
        ///   4.3
        /// </summary>
        internal enum UnitAuras : uint
        {
            AuraCount1 = 0xE90,
            AuraCount2 = 0xC14,
            AuraTable1 = 0xC10,
            AuraTable2 = 0xC18,
            AuraSize = 0x28,
            AuraSpellId = 0x8,
            AuraStack = 0xF,
            TimeLeft = 0x14,
        } ;

        #endregion

        #region Nested type: UnitName

        /// <summary>
        ///   4.3
        /// </summary>
        internal enum UnitName : uint
        {
            ObjectName1 = 0x1CC, //not sure update
            ObjectName2 = 0xB4,
            UnitName1 = 0x91C,
            UnitName2 = 0x64,
            PlayerNameCachePointer = 0x996900,
            PlayerNameMaskOffset = 0x024,
            PlayerNameBaseOffset = 0x01c,
            PlayerNameStringOffset = 0x020
        }

        #endregion

        #region Nested type: UnitSpeed

        /// <summary>
        ///   4.3
        /// </summary>
        internal enum UnitSpeed
        {
            Pointer1 = 0x100,
            Pointer2 = 0x80,
        }

        #endregion

        #region Nested type: WowObject

        /// <summary>
        ///   4.3
        /// </summary>
        internal enum WowObject
        {
            X = 0x790, // not update
            Y = X + 0x4,// not update
            Z = X + 0x8,// not update
            RotationOffset = X + 0x10,// not update
            GameObjectX = 0x110,// not update
            GameObjectY = GameObjectX + 0x4,// not update
            GameObjectZ = GameObjectX + 0x8,// not update
        }

        #endregion

        #region Nested type: Zone

        /// <summary>
        ///   4.3
        /// </summary>
        internal enum Zone : uint
        {
            ZoneText = 0xAD5C68,//.4.3.2
            ZoneID = 0xAD5D00,//.4.3.2
        }

        #endregion


        #region Nested type: UiFrame

        /// <summary>
        ///   4.3
        /// </summary>
        internal enum UiFrame
        {
            ButtonEnabledPointer = 0x200,
            ButtonEnabledMask = 0xF,
            ButtonChecked = 0x238,
            EditBoxText = 0x218,
            FirstFrame = 0xce4,
            FrameBottom = 0x68,
            FrameLeft = 0x6c,
            FrameTop = 0x70,
            FrameRight = 0x74,
            LabelText = 0xEC,
            Name = 0x1C,
            NextFrame = 0xCDC,
            RegionsFirst = 0x170,
            RegionsNext = 0x168,
            FrameBase = 0x9D2154,//.4.3.2
            ScrHeight = 0x9083CC,//.4.3.2
            ScrWidth = 0x9083C8,//.4.3.2
            Visible = 0x64,
            Visible1 = 0x1A,
            Visible2 = 1,
            CurrentFrameOffset = 0x88,
            CurrentFramePtr = 0x9D2154,//.4.3.2
        }

        #endregion
    }
}
