﻿using System;
using System.Diagnostics;
using Transvoxel.VolumeData;
using Transvoxel.VolumeData.CompactOctree;

namespace ConsoleFunctionalTest
{
    public static class Tests
    {
        public static void TestOctree()
        {
            IVolumeData octree = new CompactOctree();
            Stopwatch watch = new Stopwatch();
            /*int fail = 0;
            watch.Start();
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    for (int k = 0; k < 8; k++)
                    {

                        for (int x = 0; x < 16; x++)
                        {
                            for (int y = 0; y < 16; y++)
                            {
                                for (int z = 0; z < 16; z++)
                                {
                                    octree[x + i * 16, y + j * 16, z + k * 16] = (sbyte)(x + y + z);
                                }
                            }
                        }
                    }
                }
            }
            watch.Stop();
            Console.WriteLine("Write: " + watch.ElapsedMilliseconds);

            watch.Restart();


            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    for (int k = 0; k < 8; k++)
                    {

                        for (int x = 0; x < 16; x++)
                        {
                            for (int y = 0; y < 16; y++)
                            {
                                for (int z = 0; z < 16; z++)
                                {
                                    var test = octree[x + i * 16, y + j * 16, z + k * 16];
                                    if (test != (sbyte)(x + y + z))
                                        fail++;
                                }
                            }
                        }
                    }
                }
            }

            watch.Stop();


            Console.WriteLine("Read: " + watch.ElapsedMilliseconds);*/
/*
            for (int x = 0; x < 17; x++)
            {
                for (int y = 0; y < 16; y++)
                {
                    for (int z = 0; z < 16; z++)
                    {
                        octree[x,y,z] = (sbyte)(x + y + z);
                    }
                }
            }

            for (int x = 0; x < 16; x++)
            {
                for (int y = 0; y < 16; y++)
                {
                    for (int z = 0; z < 16; z++)
                    {
                        var test = octree[x, y, z];
                        if (test != (sbyte)(x + y + z))
                            fail++;
                    }
                }
            }
            */

            octree[16, 0, 0] = 1;
            octree[0, 8, 1] = 1;
            octree[0, -64, 0] = 1;

            Console.WriteLine(octree.ToString());
          //  Console.WriteLine(fail);
            Console.ReadLine();
        }
    }
}