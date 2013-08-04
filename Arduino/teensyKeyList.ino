char keyList(int var) {
  switch (var) {
    case 1:
      return KEY_A;
      break;
    case 2:
      return KEY_B;
      break;
    case 3:
      return KEY_C;
      break;
    case 4:
      return KEY_D;
      break;
    case 5:
      return KEY_E;
      break;
    case 6:
      return KEY_F;
      break;
    case 7:
      return KEY_G;
      break;
    case 8:
      return KEY_H;
      break;
    case 9:
      return KEY_I;
      break;
    case 10:
      return KEY_J;
      break;
    case 11:
      return KEY_K;
      break;
    case 12:
      return KEY_L;
      break;
    case 13:
      return KEY_M;
      break;
    case 14:
      return KEY_N;
      break;
    case 15:
      return KEY_O;
      break;
    case 16:
      return KEY_P;
      break;
    case 17:
      return KEY_Q;
      break;
    case 18:
      return KEY_R;
      break;
    case 19:
      return KEY_S;
      break;
    case 20:
      return KEY_T;
      break;
    case 21:
      return KEY_U;
      break;
    case 22:
      return KEY_V;
      break;
    case 23:
      return KEY_W;
      break;
    case 24:
      return KEY_X;
      break;
    case 25:
      return KEY_Y;
      break;
    case 26:
      return KEY_Z;
      break;
    case 27:
      return KEY_1;
      break;
    case 28:
      return KEY_2;
      break;
    case 29:
      return KEY_3;
      break;
    case 30:
      return KEY_4;
      break;
    case 31:
      return KEY_5;
      break;
    case 32:
      return KEY_6;
      break;
    case 33:
      return KEY_7;
      break;
    case 34:
      return KEY_8;
      break;
    case 35:
      return KEY_9;
      break;
    case 36:
      return KEY_0;
      break;
    case 37:
      return KEY_ENTER;
      break;
    case 38:
      return KEY_ESC;
      break;
    case 39:
      return KEY_BACKSPACE;
      break;
    case 40:
      return KEY_TAB;
      break;
    case 41:
      return KEY_SPACE;
      break;
    case 42:
      return KEY_MINUS;
      break;
    case 43:
      return KEY_EQUAL;
      break;
    case 44:
      return KEY_LEFT_BRACE;
      break;
    case 45:
      return KEY_RIGHT_BRACE;
      break;
    case 46:
      return KEY_BACKSLASH;
      break;
    case 47:
      return KEY_BACKSLASH;
      //return KEY_NUMBER;
      break;
    case 48:
      return KEY_SEMICOLON;
      break;
    case 49:
      return KEY_QUOTE;
      break;
    case 50:
      return KEY_TILDE;
      break;
    case 51:
      return KEY_COMMA;
      break;
    case 52:
      return KEY_PERIOD;
      break;
    case 53:
      return KEY_SLASH;
      break;
    case 54:
      return KEY_CAPS_LOCK;
      break;
    case 55:
      return KEY_F1;
      break;
    case 56:
      return KEY_F2;
      break;
    case 57:
      return KEY_F3;
      break;
    case 58:
      return KEY_F4;
      break;
    case 59:
      return KEY_F5;
      break;
    case 60:
      return KEY_F6;
      break;
    case 61:
      return KEY_F7;
      break;
    case 62:
      return KEY_F8;
      break;
    case 63:
      return KEY_F9;
      break;
    case 64:
      return KEY_F10;
      break;
    case 65:
      return KEY_F11;
      break;
    case 66:
      return KEY_F12;
      break;
    case 67:
      return KEY_PRINTSCREEN;
      break;
    case 68:
      return KEY_SCROLL_LOCK;
      break;
    case 69:
      return KEY_PAUSE;
      break;
    case 70:
      return KEY_INSERT;
      break;
    case 71:
      return KEY_HOME;
      break;
    case 72:
      return KEY_PAGE_UP;
      break;
    case 73:
      return KEY_DELETE;
      break;
    case 74:
      return KEY_END;
      break;
    case 75:
      return KEY_PAGE_DOWN;
      break;
    case 76:
      return KEY_RIGHT;
      break;
    case 77:
      return KEY_LEFT;
      break;
    case 78:
      return KEY_DOWN;
      break;
    case 79:
      return KEY_UP;
      break;
    case 80:
      return KEY_NUM_LOCK;
      break;
    case 81:
      return KEYPAD_SLASH;
      break;
    case 82:
      return KEYPAD_ASTERIX;
      break;
    case 83:
      return KEYPAD_MINUS;
      break;
    case 84:
      return KEYPAD_PLUS;
      break;
    case 85:
      return KEYPAD_ENTER;
      break;
    case 86:
      return KEYPAD_1;
      break;
    case 87:
      return KEYPAD_2;
      break;
    case 88:
      return KEYPAD_3;
      break;
    case 89:
      return KEYPAD_4;
      break;
    case 90:
      return KEYPAD_5;
      break;
    case 91:
      return KEYPAD_6;
      break;
    case 92:
      return KEYPAD_7;
      break;
    case 93:
      return KEYPAD_8;
      break;
    case 94:
      return KEYPAD_9;
      break;
    case 95:
      return KEYPAD_0;
      break;
    case 96:
      return KEYPAD_PERIOD;
      break;
      
    default:
      return KEY_A;
  }
}

char modList(int var) {
  switch (var) {
    case 1:
      return(MODIFIERKEY_CTRL);
      break;
    case 2:
      return(MODIFIERKEY_SHIFT);
      break;
    case 3:
      return(MODIFIERKEY_ALT);
      break;
    case 4:
      return(MODIFIERKEY_GUI);
      break;
      
    default:
      return(MODIFIERKEY_CTRL);
  }
}
