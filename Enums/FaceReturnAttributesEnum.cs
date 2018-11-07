using System;

namespace FacePlusPlusLib.Enums
{
    [Flags]
    public enum FaceReturnAttributesEnum
    {
        None = 0,
        Gender = 1,
        Age = 2,
        Smiling = 4,
        HeadPose = 8,
        FaceQuality = 16,
        Blur = 32,
        EyeStatus = 64,
        Emotion = 128,
        Ethnicity = 256,
        Beauty = 512,
        MouthStatus = 1024,
        EyeGaze = 2048,
        SkinStatus = 5096
    }
}