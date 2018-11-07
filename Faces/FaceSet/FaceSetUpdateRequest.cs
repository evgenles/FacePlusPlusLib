using System;
using System.Collections.Generic;
using System.IO;

namespace FacePlusPlusLib.Faces.FaceSet
{
    public class FaceSetUpdateRequest : FaceSetBaseRequest
    {
        public string NewOuterId { get; set; } = null;

        public string DisplayName { get; set; } = null;

        public string UserData { get; set; } = null;

        public List<string> Tags { get; set; } = null;

        public override (Dictionary<string, string>, Dictionary<string, Stream>) ConvertToDictionaries()
        {
            var dictionaries = base.ConvertToDictionaries();

            var tagStr = Tags != null ? string.Join(",", Tags).ToLower() : null;
            Validate(tagStr);
            return (new Dictionary<string, string>(dictionaries.Item1)
            {
                ["new_outer_id"] = NewOuterId,
                ["display_name"] = DisplayName,
                ["tags"] = tagStr,
                ["user_data"] = UserData,
            }, dictionaries.Item2);
        }

        private void Validate(string tagStr)
        {
            if (DisplayName?.Length > 256 || DisplayName?.IndexOfAny("^@,&=*'\"".ToCharArray()) > -1)
                throw new ArgumentException(
                    $"Property {nameof(DisplayName)} must be less than 256 characters, and must not contain characters ^@,&=*'\"");


            if (NewOuterId?.Length > 255 || NewOuterId?.IndexOfAny("^@,&=*'\"".ToCharArray()) > -1)
                throw new ArgumentException(
                    $"Property {nameof(OuterId)} must be less than 255 characters, and must not contain characters ^@,&=*'\"");


            if (tagStr?.Length > 255 || tagStr?.IndexOfAny("^@,&=*'\"".ToCharArray()) > -1)
                throw new ArgumentException(
                    $"Property {nameof(Tags)} must be less than 255 characters, and must not contain characters ^@,&=*'\"");

            if (UserData?.Length * sizeof(char) > 16 * 1024 || UserData?.IndexOfAny("^@,&=*'\"".ToCharArray()) > -1)
                throw new ArgumentException(
                    $"Property {nameof(DisplayName)} must be less than 16KB, and must not contain characters ^@,&=*'\"");
        }
    }
}