using SharpDX.DirectInput;

namespace ControllerInputLogger
{
    public static class JoystickUpdateHelper
    {
        public static string ToMoreBetterString(this JoystickUpdate update)
        {
            return $"{update.Timestamp % 10000}: {update.GetOffsetFriendlyName()}";
        }

        public static string GetOffsetFriendlyName(this JoystickUpdate update)
        {
            switch (update.Offset)
            {
                case JoystickOffset.X:
                    if (update.Value == 65535)
                        return "Right Press";
                    if (update.Value == 0)
                        return "Left Press";
                    else
                        return "Release";
                case JoystickOffset.Y:
                        if (update.Value == 0)
                            return "Up Press";
                        if (update.Value == 65535)
                            return "Down Press";
                        else
                            return "Release";
                case JoystickOffset.Buttons0:
                    if (update.Value == 128)
                        return "X Press";
                    else
                        return "X Release";
                case JoystickOffset.Buttons1:
                    if (update.Value == 128)
                        return "A Press";
                    else
                        return "A Release";
                case JoystickOffset.Buttons2:
                    if (update.Value == 128)
                        return "B Press";
                    else
                        return "B Release";
                case JoystickOffset.Buttons3:
                    if (update.Value == 128)
                        return "Y Press";
                    else
                        return "Y Release";
                case JoystickOffset.Buttons4:
                    if (update.Value == 128)
                        return "L Press";
                    else
                        return "L Release";
                case JoystickOffset.Buttons5:
                    if (update.Value == 128)
                        return "R Press";
                    else
                        return "R Release";
                default:
                    return update.Offset.ToString();
            }
        }
    }
}
