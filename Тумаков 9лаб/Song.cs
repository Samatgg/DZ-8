﻿using System;
using System.Collections.Generic;

namespace Тумаков_9лаб
{
    internal class Song
    {
        private string name { get; set; }
        private string author { get; set; }
        public Song previous { get; set; }
        public Song()
        {

        }
        public Song(string name, string author)
        {
            this.name = name;
            this.author = author;
            previous = null;
        }
        public Song(string name, string author, Song previous)
        {
            this.name = name;
            this.author = author;
            this.previous = previous;
        }
        public void FillName()
        {
            Console.WriteLine("Введите название песни: ");
            name = Console.ReadLine();
            Console.WriteLine("Песня добавлена");
        }
        public void FillAuthor()
        {
            Console.WriteLine("Введите автора песни: ");
            author = Console.ReadLine();
            Console.WriteLine("Автор добавлен");
        }
        public void Previous(List<Song> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                list[i].FillName();
                list[i].FillAuthor();
                if (i != 0)
                {
                    list[i].previous = list[i - 1];

                }
                else
                {
                    Console.WriteLine("Предыдущей песни нет - это первая в списке\n");

                }
            }
        }
        public string PrintTitle()
        {
            string info = name + " - " + author;
            return info;
        }
        public override bool Equals(object d)
        {
            Song song = d as Song;
            if (song != null && (song.name == name) && (song.author == author))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
