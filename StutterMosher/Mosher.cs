using System.IO;

namespace StutterMosher
{
    public class Mosher
    {
        Stream InputStream { get; }
        Stream OutputStream { get; }

        public Mosher(Stream inputStream, Stream outputStream)
        {
            InputStream = inputStream;
            OutputStream = outputStream;
        }

        public void Mosh(int iterations)
        {
            bool iFrameYet = false;
            while (true)
            {
                Frame frame = Frame.ReadFromStream(InputStream);
                if (frame == null)
                    break;
                if (!iFrameYet)
                {
                    frame.WriteToStream(OutputStream);
                    if (frame.IsIFrame) iFrameYet = true;
                }
                else if (frame.IsPFrame)
                {
                    for (int n = 0; n < iterations; n++)
                        frame.WriteToStream(OutputStream);
                }
            }
        }
    }
}
