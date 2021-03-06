using System;

namespace BlackBerry.Screen
{
	internal class KeyCodeConstants {
		public const uint UNICODE_PRIVATE_USE_AREA_FIRST = 0xe000;
		public const uint KEYCODE_PC_KEYS = UNICODE_PRIVATE_USE_AREA_FIRST + 0x1000;
		public const uint KEYCODE_CONSUMER_KEYS = (KEYCODE_PC_KEYS + 0x200);
	}

	public enum KeyCode : uint
	{
		Pause = (KeyCodeConstants.KEYCODE_PC_KEYS + 0x13),
		ScrollLock = (KeyCodeConstants.KEYCODE_PC_KEYS + 0x14),
		Print = (KeyCodeConstants.KEYCODE_PC_KEYS + 0x61),
		SysReq = (KeyCodeConstants.KEYCODE_PC_KEYS + 0x6a),
		Break = (KeyCodeConstants.KEYCODE_PC_KEYS + 0x6b),

		Escape = (KeyCodeConstants.KEYCODE_PC_KEYS + 0x1b),
		Backspace = (KeyCodeConstants.KEYCODE_PC_KEYS + 0x08),
		Tab = (KeyCodeConstants.KEYCODE_PC_KEYS + 0x09),
		BackTab = (KeyCodeConstants.KEYCODE_PC_KEYS + 0x89),
		Return = (KeyCodeConstants.KEYCODE_PC_KEYS + 0x0d),
		CapsLock = (KeyCodeConstants.KEYCODE_PC_KEYS + 0xe5),
		LeftShift = (KeyCodeConstants.KEYCODE_PC_KEYS + 0xe1),
		RightShift = (KeyCodeConstants.KEYCODE_PC_KEYS + 0xe2),
		LeftCtrl = (KeyCodeConstants.KEYCODE_PC_KEYS + 0xe3),
		RightCtrl = (KeyCodeConstants.KEYCODE_PC_KEYS + 0xe4),
		LeftAlt = (KeyCodeConstants.KEYCODE_PC_KEYS + 0xe9),
		RightAlt = (KeyCodeConstants.KEYCODE_PC_KEYS + 0xea),
		Menu = (KeyCodeConstants.KEYCODE_PC_KEYS + 0x67),
		LeftHyper = (KeyCodeConstants.KEYCODE_PC_KEYS + 0xed),
		RightHyper = (KeyCodeConstants.KEYCODE_PC_KEYS + 0xee),
		
		Insert = (KeyCodeConstants.KEYCODE_PC_KEYS + 0x63),
		Home = (KeyCodeConstants.KEYCODE_PC_KEYS + 0x50),
		PageUp = (KeyCodeConstants.KEYCODE_PC_KEYS + 0x55),
		Delete = (KeyCodeConstants.KEYCODE_PC_KEYS + 0xff),
		End = (KeyCodeConstants.KEYCODE_PC_KEYS + 0x57),
		PageDown = (KeyCodeConstants.KEYCODE_PC_KEYS + 0x56),
		Left = (KeyCodeConstants.KEYCODE_PC_KEYS + 0x51),
		Right = (KeyCodeConstants.KEYCODE_PC_KEYS + 0x53),
		Up = (KeyCodeConstants.KEYCODE_PC_KEYS + 0x52),
		Down = (KeyCodeConstants.KEYCODE_PC_KEYS + 0x54),
		
		NumLock = (KeyCodeConstants.KEYCODE_PC_KEYS + 0x7f),
		KeypadPlus = (KeyCodeConstants.KEYCODE_PC_KEYS + 0xab),
		KeypadMinus = (KeyCodeConstants.KEYCODE_PC_KEYS + 0xad),
		KeypadMultiply = (KeyCodeConstants.KEYCODE_PC_KEYS + 0xaa),
		KeypadDivide = (KeyCodeConstants.KEYCODE_PC_KEYS + 0xaf),
		KeypadEnter = (KeyCodeConstants.KEYCODE_PC_KEYS + 0x8d),
		KeypadHome = (KeyCodeConstants.KEYCODE_PC_KEYS + 0xb7),
		KeypadUp = (KeyCodeConstants.KEYCODE_PC_KEYS + 0xb8),
		KeypadPageUp = (KeyCodeConstants.KEYCODE_PC_KEYS + 0xb9),
		KeypadLeft = (KeyCodeConstants.KEYCODE_PC_KEYS + 0xb4),
		KeypadFive = (KeyCodeConstants.KEYCODE_PC_KEYS + 0xb5),
		KeypadRight = (KeyCodeConstants.KEYCODE_PC_KEYS + 0xb6),
		KeypadEnd = (KeyCodeConstants.KEYCODE_PC_KEYS + 0xb1),
		KeypadDown = (KeyCodeConstants.KEYCODE_PC_KEYS + 0xb2),
		KeypadPageDown = (KeyCodeConstants.KEYCODE_PC_KEYS + 0xb3),
		KeypadInsert = (KeyCodeConstants.KEYCODE_PC_KEYS + 0xb0),
		KeypadDelete = (KeyCodeConstants.KEYCODE_PC_KEYS + 0xae),
		
		F1 = (KeyCodeConstants.KEYCODE_PC_KEYS + 0xbe),
		F2 = (KeyCodeConstants.KEYCODE_PC_KEYS + 0xbf),
		F3 = (KeyCodeConstants.KEYCODE_PC_KEYS + 0xc0),
		F4 = (KeyCodeConstants.KEYCODE_PC_KEYS + 0xc1),
		F5 = (KeyCodeConstants.KEYCODE_PC_KEYS + 0xc2),
		F6 = (KeyCodeConstants.KEYCODE_PC_KEYS + 0xc3),
		F7 = (KeyCodeConstants.KEYCODE_PC_KEYS + 0xc4),
		F8 = (KeyCodeConstants.KEYCODE_PC_KEYS + 0xc5),
		F9 = (KeyCodeConstants.KEYCODE_PC_KEYS + 0xc6),
		F10 = (KeyCodeConstants.KEYCODE_PC_KEYS + 0xc7),
		F11 = (KeyCodeConstants.KEYCODE_PC_KEYS + 0xc8),
		F12 = (KeyCodeConstants.KEYCODE_PC_KEYS + 0xc9),

		Power = (KeyCodeConstants.KEYCODE_CONSUMER_KEYS + 0x00),
		Reset = (KeyCodeConstants.KEYCODE_CONSUMER_KEYS + 0x01),
		Sleep = (KeyCodeConstants.KEYCODE_CONSUMER_KEYS + 0x02),
		SleepAfter = (KeyCodeConstants.KEYCODE_CONSUMER_KEYS + 0x03),
		SleepMode = (KeyCodeConstants.KEYCODE_CONSUMER_KEYS + 0x04),
		Illumination = (KeyCodeConstants.KEYCODE_CONSUMER_KEYS + 0x05),
		//KEYCODE_MENU = (KeyCodeConstants.KEYCODE_CONSUMER_KEYS + 0x06),
		MenuPick = (KeyCodeConstants.KEYCODE_CONSUMER_KEYS + 0x07),
		MenuUp = (KeyCodeConstants.KEYCODE_CONSUMER_KEYS + 0x08),
		MenuDown = (KeyCodeConstants.KEYCODE_CONSUMER_KEYS + 0x09),
		MenuLeft = (KeyCodeConstants.KEYCODE_CONSUMER_KEYS + 0x0a),
		MenuRight = (KeyCodeConstants.KEYCODE_CONSUMER_KEYS + 0x0b),
		MenuEscape = (KeyCodeConstants.KEYCODE_CONSUMER_KEYS + 0x0c),
		MenuValueIncrease = (KeyCodeConstants.KEYCODE_CONSUMER_KEYS + 0x0d),
		MenuValueDecrease = (KeyCodeConstants.KEYCODE_CONSUMER_KEYS + 0x0e),
		Snapshot = (KeyCodeConstants.KEYCODE_CONSUMER_KEYS + 0x0f),
		Play = (KeyCodeConstants.KEYCODE_CONSUMER_KEYS + 0x10),
		//KEYCODE_PAUSE = (KeyCodeConstants.KEYCODE_CONSUMER_KEYS + 0x11),
		Record = (KeyCodeConstants.KEYCODE_CONSUMER_KEYS + 0x12),
		FastForward = (KeyCodeConstants.KEYCODE_CONSUMER_KEYS + 0x13),
		Rewind = (KeyCodeConstants.KEYCODE_CONSUMER_KEYS + 0x14),
		ScanNext = (KeyCodeConstants.KEYCODE_CONSUMER_KEYS + 0x15),
		ScanPrevious = (KeyCodeConstants.KEYCODE_CONSUMER_KEYS + 0x16),
		Stop = (KeyCodeConstants.KEYCODE_CONSUMER_KEYS + 0x17),
		Eject = (KeyCodeConstants.KEYCODE_CONSUMER_KEYS + 0x18),
		StopEject = (KeyCodeConstants.KEYCODE_CONSUMER_KEYS + 0x19),
		PlayPause = (KeyCodeConstants.KEYCODE_CONSUMER_KEYS + 0x1a),
		PlaySkip = (KeyCodeConstants.KEYCODE_CONSUMER_KEYS + 0x1b),
		Mute = (KeyCodeConstants.KEYCODE_CONSUMER_KEYS + 0x1c),
		VolumeUp = (KeyCodeConstants.KEYCODE_CONSUMER_KEYS + 0x1d),
		VolumeDown = (KeyCodeConstants.KEYCODE_CONSUMER_KEYS + 0x1e),
		
		AcNew = (KeyCodeConstants.KEYCODE_CONSUMER_KEYS + 0x20),
		AcOpen = (KeyCodeConstants.KEYCODE_CONSUMER_KEYS + 0x21),
		AcClose = (KeyCodeConstants.KEYCODE_CONSUMER_KEYS + 0x22),
		AcExit = (KeyCodeConstants.KEYCODE_CONSUMER_KEYS + 0x23),
		AcMaximize = (KeyCodeConstants.KEYCODE_CONSUMER_KEYS + 0x24),
		AcMinimize = (KeyCodeConstants.KEYCODE_CONSUMER_KEYS + 0x25),
		AcSave = (KeyCodeConstants.KEYCODE_CONSUMER_KEYS + 0x26),
		AcPrint = (KeyCodeConstants.KEYCODE_CONSUMER_KEYS + 0x27),
		AcProperties = (KeyCodeConstants.KEYCODE_CONSUMER_KEYS + 0x28),
		AcUndo = (KeyCodeConstants.KEYCODE_CONSUMER_KEYS + 0x29),
		AcCopy = (KeyCodeConstants.KEYCODE_CONSUMER_KEYS + 0x2a),
		AcCut = (KeyCodeConstants.KEYCODE_CONSUMER_KEYS + 0x2b),
		AcPaste = (KeyCodeConstants.KEYCODE_CONSUMER_KEYS + 0x2c),
		AcSelectAll = (KeyCodeConstants.KEYCODE_CONSUMER_KEYS + 0x2d),
		AcFind = (KeyCodeConstants.KEYCODE_CONSUMER_KEYS + 0x2e),
		AcFindAndReplace = (KeyCodeConstants.KEYCODE_CONSUMER_KEYS + 0x2f),
		AcGoTo = (KeyCodeConstants.KEYCODE_CONSUMER_KEYS + 0x30),
		AcHome = (KeyCodeConstants.KEYCODE_CONSUMER_KEYS + 0x31),
		AcBack = (KeyCodeConstants.KEYCODE_CONSUMER_KEYS + 0x32),
		AcForward = (KeyCodeConstants.KEYCODE_CONSUMER_KEYS + 0x33),
		AcStop = (KeyCodeConstants.KEYCODE_CONSUMER_KEYS + 0x34),
		AcRefresh = (KeyCodeConstants.KEYCODE_CONSUMER_KEYS + 0x35),
		AcPreviousLink = (KeyCodeConstants.KEYCODE_CONSUMER_KEYS + 0x36),
		AcNextLink = (KeyCodeConstants.KEYCODE_CONSUMER_KEYS + 0x37),
		AcBookmarks = (KeyCodeConstants.KEYCODE_CONSUMER_KEYS + 0x38),
		AcHistory = (KeyCodeConstants.KEYCODE_CONSUMER_KEYS + 0x39),
		AcZoomIn = (KeyCodeConstants.KEYCODE_CONSUMER_KEYS + 0x3a),
		AcZoomOut = (KeyCodeConstants.KEYCODE_CONSUMER_KEYS + 0x3b),
		AcZoom = (KeyCodeConstants.KEYCODE_CONSUMER_KEYS + 0x3c),
		AcFullscreen = (KeyCodeConstants.KEYCODE_CONSUMER_KEYS + 0x3d),
		AcNormalView = (KeyCodeConstants.KEYCODE_CONSUMER_KEYS + 0x3e),
		AcViewToggle = (KeyCodeConstants.KEYCODE_CONSUMER_KEYS + 0x3f),
		AcScrollUp = (KeyCodeConstants.KEYCODE_CONSUMER_KEYS + 0x40),
		AcScrollDown = (KeyCodeConstants.KEYCODE_CONSUMER_KEYS + 0x41),
		AcScroll = (KeyCodeConstants.KEYCODE_CONSUMER_KEYS + 0x42),
		AcPanLeft = (KeyCodeConstants.KEYCODE_CONSUMER_KEYS + 0x43),
		AcPanRight = (KeyCodeConstants.KEYCODE_CONSUMER_KEYS + 0x44),
		AcPan = (KeyCodeConstants.KEYCODE_CONSUMER_KEYS + 0x45)
	}
}

