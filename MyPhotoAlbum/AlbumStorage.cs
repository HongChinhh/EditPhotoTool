﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Manning.MyPhotoAlbum
{
    public class AlbumStorageExeption : Exception
    {
        public AlbumStorageExeption() : base() { }
        public AlbumStorageExeption(string msg) : base(msg) { }
        public AlbumStorageExeption(string msg, Exception inner) : base(msg, inner) { }
    }
    public class AlbumStorage
    {
        static private int CurrentVersion = 91;
        static public void WriteAlbum(PhotoAlbum album, string path)
        {
            StreamWriter sw = null;
            try
            {
                sw = new StreamWriter(path, false);
                sw.WriteLine(CurrentVersion.ToString());

                //save album properties 
                sw.WriteLine(album.Title);
                sw.WriteLine(album.PhotoDecriptor.ToString());

                foreach (Photograph p in album)
                    WritePhoto(sw, p);
                album.HasChanged = false;
            }
            catch (UnauthorizedAccessException uax)
            {
                throw new AlbumStorageExeption("Unable to access album" + path, uax);
            }
            finally
            {
                if (sw != null)
                    sw.Close();
            }
        }
        static private void WritePhoto(StreamWriter sw, Photograph p)
        {
            sw.WriteLine(p.Filename);
            sw.WriteLine(p.Caption != null ? p.Caption : "");
            sw.WriteLine(p.DateTaken.ToString());
            sw.WriteLine(p.Photographer != null ? p.Photographer : "");
            sw.WriteLine(p.Note != null ? p.Note : "");
        }
        static public PhotoAlbum ReadAlbum(string path)
        {
            StreamReader sr = null;
            try
            {
                sr = new StreamReader(path);
                string version = sr.ReadLine();
                PhotoAlbum album = new PhotoAlbum();
                switch (version)
                {
                    case "63":
                        ReadAlbumV63(sr, album);
                        break;
                    case "91":
                        ReadAlbumV91(sr, album);
                        break;
                    default:
                        throw new AlbumStorageExeption("Unrecognized album version");
                }
                album.HasChanged = false;
                return album;
            }
            catch (FileNotFoundException fnx)
            {
                throw new AlbumStorageExeption(" Unable to read album" + path, fnx);
            }
            finally
            {
                if (sr != null)
                    sr.Close();
            }
        }
        static private void ReadAlbumV63(StreamReader sr, PhotoAlbum album)
        {
            Photograph p;
            do
            {
                p = ReadPhotoV63(sr);
                if (p != null)
                    album.Add(p);
            } while (p != null);
        }

        static private void ReadAlbumV91(StreamReader sr, PhotoAlbum album)
        {
            // read album properties
            album.Title = sr.ReadLine();
            string enumVal = sr.ReadLine();
            album.PhotoDecriptor = (PhotoAlbum.DescriptorOption)Enum.Parse(typeof(PhotoAlbum.DescriptorOption), enumVal);

            // version 91 finishes with version 63
            ReadAlbumV63(sr, album);
        }


        static private Photograph ReadPhotoV63(StreamReader sr)
        {
            string file = sr.ReadLine();
            if (file == null || file.Length == 0)
                return null;
            Photograph p = new Photograph(file);
            p.Caption = sr.ReadLine();
            p.DateTaken = DateTime.Parse(sr.ReadLine());
            p.Photographer = sr.ReadLine();
            p.Note = sr.ReadLine();
            return p;
        }
    }
}
