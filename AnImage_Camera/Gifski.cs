using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace AnImage_Camera
{
    public class Gifski
    {
        [StructLayout(LayoutKind.Sequential)]
        public struct Settings
        {
            public uint width;
            public uint height;
            public byte quality;
            public bool once;
            public bool fast;
        }

        public enum Error
        {
            Ok = 0,
            Null_arg,
            Invalid_state,
            Quant,
            Gif,
            Thread_lost,
            Not_found,
            Permission_denied,
            Already_exists,
            Invalid_input,
            Timed_out,
            Write_zero,
            Interrupted,
            Unexpected_eof,
            Aborted,
            Other,
        };

        [DllImport("gifski.dll", EntryPoint = "gifski_new")]
        public static extern IntPtr New(Settings settings);

        [DllImport("gifski.dll", EntryPoint = "gifski_add_frame_png_file")]
        public static extern Error AddFrame_pngfile(IntPtr handle, uint index, string file_path, ushort delay);

        [DllImport("gifski.dll", EntryPoint = "gifski_add_frame_rgba")]
        public static extern Error AddFrame_rgba(IntPtr handle, uint index, uint width, uint height, byte[] pixels, ushort delay);

        [DllImport("gifski.dll", EntryPoint = "gifski_add_frame_argb")]
        public static extern Error AddFrame_argb(IntPtr handle, uint index, uint width, uint bytes_per_row, uint height, byte[] pixels, ushort delay);

        [DllImport("gifski.dll", EntryPoint = "gifski_add_frame_rgb")]
        public static extern Error AddFrame_rgb(IntPtr handle, uint index, uint width, uint bytes_per_row, uint height, byte[] pixels, ushort delay);

        [DllImport("gifski.dll", EntryPoint = "gifski_end_adding_frames")]
        public static extern Error EndAddingFrames(IntPtr handle);

        [DllImport("gifski.dll", EntryPoint = "gifski_write")]
        public static extern Error Save(IntPtr handle, string destination);

        [DllImport("gifski.dll", EntryPoint = "gifski_drop")]
        public static extern void Drop(IntPtr handle);
    }
}
