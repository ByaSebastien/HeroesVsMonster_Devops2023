﻿using static System.Net.WebRequestMethods;
using System.Threading.Tasks;
using System;

namespace HeroesVsMonster.Utils
{
    public static class Pictures
    {
        public static string[] Logo = new string[]
            {
                "┌─────────────────────────────────────────────────────────────────────┐" ,
                "│                                                                     │" ,
                "│            █   █   █████   █████   █████   █████   █████            │" ,
                "│            █   █   █       █   █   █   █   █       █                │" ,
                "│            █████   ████    █████   █   █   ████    █████            │" ,
                "│            █   █   █       █  █    █   █   █           █            │" ,
                "│            █   █   █████   █   █   █████   █████   █████            │" ,
                "│                                                                     │" ,
                "│                            █   █   █████                            │" ,
                "│                            █   █   █                                │" ,
                "│                            ██ ██   █████                            │" ,
                "│                             █ █        █                            │" ,
                "│                              █     █████                            │" ,
                "│                                                                     │" ,
                "│    █   █   █████   █   █   █████   █████   █████   █████   █████    │" ,
                "│    ██ ██   █   █   ██  █   █         █     █       █   █   █        │" ,
                "│    █ █ █   █   █   █ █ █   █████     █     ████    █████   █████    │" ,
                "│    █   █   █   █   █  ██       █     █     █       █  █        █    │" ,
                "│    █   █   █████   █   █   █████     █     █████   █   █   █████    │" ,
                "│                                                                     │" ,
                "└─────────────────────────────────────────────────────────────────────┘"
            };
        public static string[] GameBackground = new string[]
        {
                "                                                                                                                                                            " ,
                "   ┌── INFORMATIONS ────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────┐   " ,
                "   │                                                                                                                                                    │   " ,
                "   │                                                                                                                                                    │   " ,
                "   │                                                                                                                                                    │   " ,
                "   └────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────┘   " ,
                "                                                                                                                                                            " ,
                "   ┌─── JEU ──────────────────────────────────────────────────────────────────────────────────────────────────┐   ┌── INFO HERO ────────────────────────┐   " ,
                "   │                                                                                                          │   │                                     │   " ,
                "   │                                                                                                          │   │   Nom :                             │   " ,//+9
                "   │                                                                                                          │   │   Race :                            │   " ,//+127
                "   │                                                                                                          │   │   Classe :                          │   " ,
                "   │                                                                                                          │   │   Level :                           │   " ,
                "   │                                                                                                          │   │   Hp :                              │   " ,
                "   │                                                                                                          │   │   MP :                              │   " ,
                "   │                                                                                                          │   │   XP :                              │   " ,
                "   │                                                                                                          │   │                                     │   " ,
                "   │                                                                                                          │   └─────────────────────────────────────┘   " ,
                "   │                                                                                                          │                                             " ,
                "   │                                                                                                          │   ┌── EQUIPEMENT ───────────────────────┐   " ,
                "   │                                                                                                          │   │                                     │   " ,
                "   │                                                                                                          │   │   Arme :                            │   " ,//+21
                "   │                                                                                                          │   │   Casque :                          │   " ,
                "   │                                                                                                          │   │   Armure :                          │   " ,
                "   │                                                                                                          │   │   Gants :                           │   " ,
                "   │                                                                                                          │   │   Bottes :                          │   " ,
                "   │                                                                                                          │   │                                     │   " ,
                "   │                                                                                                          │   └─────────────────────────────────────┘   " ,
                "   │                                                                                                          │                                             " ,
                "   │                                                                                                          │   ┌── INFO ENNEMI ──────────────────────┐   " ,
                "   │                                                                                                          │   │                                     │   " ,
                "   │                                                                                                          │   │   Type :                            │   " ,//+31
                "   │                                                                                                          │   │   HP :                              │   " ,
                "   │                                                                                                          │   │   MP :                              │   " ,
                "   │                                                                                                          │   │                                     │   " ,
                "   └──────────────────────────────────────────────────────────────────────────────────────────────────────────┘   └─────────────────────────────────────┘   " ,
                "                                                                                                                                                            " ,
                "   ┌── ACTIONS ─────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────┐   " ,
                "   │                                                                                                                                                    │   " ,
                "   │                                                                                                                                                    │   " ,
                "   │                                                                                                                                                    │   " ,//40
                "   │                                                                                                                                                    │   " ,
                "   │                                                                                                                                                    │   " ,
                "   └────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────┘   " ,
                "                                                                                                                                                            "
            };
        public static string[] Map = new string[]
        {
            "██████████████████████████████████████████████████████████████████████████████████████████████████████████",
            "█                                                                                                        █",
            "█                                                                                                        █",
            "█                                                                                                        █",
            "█                                                                                                        █",
            "█                                                                                                        █",
            "█                                                                                                        █",
            "█                                                                                                        █",
            "█                                                                                                        █",
            "█                                                                                                        █",
            "█                                                                                                        █",
            "█                                                                                                        █",
            "█                                                                                                        █",
            "█                                                                                                        █",
            "█                                                                                                        █",
            "█                                                                                                        █",
            "█                                                                                                        █",
            "█                                                                                                        █",
            "█                                                                                                        █",
            "█                                                                                                        █",
            "█                                                                                                        █",
            "█                                                                                                        █",
            "█                                                                                                        █",
            "█                                                                                                        █",
            "█                                                                                                        █",
            "█                                                                                                        █",
            "██████████████████████████████████████████████████████████████████████████████████████████████████████████",
        };
        public static string[] Wolf = new string[]
        {
            "@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@",
            "@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@",
            "@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@'~~~     ~~~`@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@",
            "@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@'                     `@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@",
            "@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@'                           `@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@",
            "@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@'                               `@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@",
            "@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@'                                   `@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@",
            "@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@'                                     `@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@",
            "@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@'                                       `@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@",
            "@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@                                         @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@",
            "@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@'                                         `@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@",
            "@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@                                           @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@",
            "@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@                                           @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@",
            "@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@                       n,                  @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@",
            "@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@                     _/ | _                @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@",
            "@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@                    /'  `'/                @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@",
            "@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@a                 <~    .'                a@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@",
            "@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@                 .'    |                 @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@",
            "@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@a              _/      |                a@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@",
            "@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@a           _/      `.`.              a@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@",
            "@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@a     ____/ '   \\__ | |______       a@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@",
            "@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@a__/___/      /__\\ \\ \\     \\___.a@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@",
            "@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@/  (___.'\\_______)\\_|_|        \\@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@",
            "@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@|\\______________________________/|@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@",
            "@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@",
            "@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@",
            "@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@",

        };
        public static string[] Troll = new string[]
        {
            "⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⠿⢿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿",
            "⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⡿⠿⠿⠟⠛⠛⠛⠛⠛⠛⠛⠻⠿⠿⢿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⠿⠟⠋⣁⣤⣤⣤⡈⠙⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿",
            "⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⡿⠟⠋⢉⣠⣤⡴⢰⣶⣾⡏⣴⣿⣿⣿⡇⣶⣶⣶⣤⡄⣌⡉⠙⠛⠿⠟⠋⠉⠀⢤⣶⣿⣿⣿⣿⣿⣿⡄⠸⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿",
            "⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⠿⠋⢁⣠⣴⡟⣼⣿⡿⠃⠿⣿⣿⠃⠿⣿⣿⣿⠃⠿⣿⣿⣿⢀⣿⣿⣿⣧⢲⣤⣀⠁⠙⠰⠬⣙⠻⣿⣿⣿⣿⣿⠀⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿",
            "⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⠿⠋⢁⣴⠖⣸⣿⡟⠀⢻⣿⣷⣄⣴⣿⣿⣄⣠⣿⣿⣇⣀⣴⣿⣿⠁⠈⣿⣿⣿⣿⢀⣿⣿⣿⠑⣦⣀⠘⢫⠀⣌⠻⣿⣿⠀⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿",
            "⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⠟⠁⡠⢠⣾⡏⠀⣿⣿⣧⣤⣾⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣟⠋⠈⣿⣿⣿⠀⣿⣿⣷⣄⠈⢡⠰⠌⠻⠀⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿",
            "⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⠟⠁⣠⣾⠃⠘⢿⣷⣾⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣷⣾⣿⣿⠋⠀⣻⣿⣿⣿⡁⣄⠀⢠⠰⠀⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿",
            "⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⡿⠁⣠⠀⣿⣿⣤⣴⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣶⣶⣿⣿⣿⣿⡇⣿⣷⡄⠀⠀⢻⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿",
            "⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⡟⠁⣼⡿⠀⠻⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⡿⠿⠟⠛⠛⠛⠛⠋⢉⣉⣉⣉⠉⠉⠉⠉⢉⣉⣉⡉⠙⠻⢿⣿⣿⣿⡏⠀⢸⣿⣿⠀⡀⠘⢿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿",
            "⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⠁⢸⣿⣇⣀⣼⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⠿⠋⢁⡠⠤⠤⠶⠬⠭⠭⠭⠥⠤⠴⠶⢒⣻⣿⣛⡻⠶⠦⢭⣉⡻⢶⣤⡈⠛⢿⣿⣶⣿⣿⣿⠠⣿⣦⡀⠙⢿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿",
            "⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⡿⢠⢸⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⠟⢁⣤⣾⣿⣿⠿⢛⣛⣛⣛⣻⠿⣿⣿⣿⣿⣿⠍⣩⣭⣥⣬⣭⣑⡀⢍⡓⢬⣙⠶⣄⠙⠿⣿⣯⠀⢀⣿⣿⣿⡆⡀⠙⢿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿",
            "⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣇⠀⠈⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⠀⢸⣿⣿⡿⢡⣾⣿⣿⣿⣿⣆⢹⣿⣿⣿⣿⡟⢸⣿⣿⠿⠿⠿⢿⣿⣷⣌⠢⡙⢷⣽⣷⣄⠈⠻⣿⣿⣿⣿⣿⢳⣿⣦⡀⠙⢿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿",
            "⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⠀⣶⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⠿⠋⣠⣿⣿⣿⠷⠞⠋⣉⡉⠙⠛⠻⣼⣿⣿⣿⣿⡿⠋⢁⣤⣶⠀⠀⠀⠀⣈⠙⠿⠿⢿⣿⣿⡿⠷⠄⠈⠻⣿⣿⡃⢀⣿⣿⣯⢠⡀⠙⢿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿",
            "⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⡁⠀⢻⣿⣿⣿⣿⣿⣿⣿⣿⣿⠋⠠⠚⠡⢐⣶⣶⣶⣶⣶⣶⣤⣤⣄⡀⠈⣁⣹⣿⣿⣄⠘⠋⣁⣤⣦⡀⠰⣶⣤⣤⣬⡡⠶⠈⠀⠐⠒⢶⣦⠀⡈⠻⣿⣿⣿⣿⠟⠈⣿⡆⠈⢿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿",
            "⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⠀⠈⢿⣿⣿⣿⣿⣿⣿⣿⣿⠀⢡⡟⡘⢁⣠⢄⡈⠛⠿⠛⣿⣿⣿⡗⠀⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣷⣤⣀⣉⣉⣁⣠⣤⡶⠈⣿⣷⡄⠹⣷⢰⡄⢹⣿⣿⣿⣦⣴⣿⠧⣷⠀⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿",
            "⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⠛⠈⢳⡄⠻⣿⣿⣿⣿⣿⣿⣿⠀⠞⣇⠻⣿⡟⠀⣷⡶⠶⠿⠟⠛⠁⣤⣾⣿⣿⣿⣿⣿⣀⡈⢉⣙⣛⣛⡻⣿⣿⡿⠟⠋⣁⣤⡄⠈⠛⢿⠀⣿⢸⡇⢸⣿⣿⣿⣿⣿⣇⣀⣼⡇⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿",
            "⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣦⣤⣾⣸⣷⡌⠹⣿⣿⣿⣿⣿⣆⠐⢬⣅⠛⠀⠀⠁⠀⠀⠀⠀⠀⠀⠙⢿⠿⣿⣍⠀⠀⠈⠋⠈⠛⠿⠟⠛⠉⣁⠀⣴⣾⡿⠋⠀⣾⣿⡇⢰⠏⡜⠁⣼⣿⣿⣿⣿⣿⣿⣿⣿⠁⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿",
            "⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⡿⠉⠀⢙⣿⣴⡈⠙⢿⣿⣿⣿⡧⠈⠁⠀⠀⠀⠀⢀⡀⠀⠀⠀⠀⠀⠀⠀⠚⠁⠀⠀⠀⠀⠀⠀⠀⠀⠛⠿⠏⠀⠉⣁⠄⢀⣾⣿⣿⣭⠒⠊⢀⣼⣿⣿⣿⣿⣿⣿⣿⣿⠇⠀⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿",
            "⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣶⣶⣾⣿⣿⡇⣷⣄⠙⢿⠏⠀⠀⢀⣄⠀⠈⠂⠸⠟⠀⢿⣶⣶⠀⣰⣶⣾⠀⢾⣷⣦⠄⠀⠀⠀⠀⠀⠀⠀⠀⡾⠋⣠⣿⣿⣿⣿⠟⢀⣴⣿⣿⣿⣿⣿⣿⣿⣿⠟⠁⢠⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿",
            "⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⡟⠁⢻⣿⣷⣀⢀⣀⠀⣿⣿⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⣀⣠⡄⠀⠀⠀⠀⠀⠀⠀⣼⣿⣿⣿⣿⡟⢀⣾⣿⣿⣿⣿⣿⡿⠿⠋⢠⣴⢡⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿",
            "⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣧⣤⣤⣿⣿⡟⠼⣿⠀⣿⣿⡄⠠⠀⢆⠀⣤⠀⢠⣤⡄⠠⣤⣤⣶⠀⣾⣿⣿⣿⣷⡀⠢⠀⠀⠀⠀⠀⠘⣿⣿⡿⠋⠠⠞⠛⠛⠛⠛⠉⢁⣤⣴⠆⣿⣅⣀⣽⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿",
            "⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⡏⠀⢀⣿⠀⣿⣿⣿⣦⣀⡈⠀⠘⠣⠈⠻⠧⠀⠿⠿⠿⠀⠻⠛⠛⠋⣉⣤⣴⡶⠆⡀⠀⠀⠀⠐⠊⠀⣲⣶⡶⣰⣶⣾⣿⠃⣾⣿⠃⠀⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿",
            "⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⡇⢠⣿⡈⣿⣧⡙⢿⣿⣿⣶⣶⣶⣶⣶⣶⣶⣶⣶⣶⣿⡿⠿⢛⡉⠴⢒⣩⠴⠆⠀⠀⠀⣏⣀⣰⡏⠀⢹⣿⡿⠋⢀⣨⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿",
            "⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⡇⠸⣿⣧⣌⡻⢿⣶⣮⣭⣭⣭⣭⡭⠽⡿⠿⠭⢉⣁⣀⣬⣥⣶⠶⠋⢉⣠⣴⣾⣿⡀⠀⢸⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿",
            "⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣷⡀⠹⣿⣿⣿⣷⣶⣶⣶⣶⣶⣶⣾⣿⣿⣿⣿⡿⠿⠿⠛⣉⣠⣴⣾⣿⣿⣿⣿⣿⣿⡄⠘⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿",
            "⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣦⣈⠙⠛⠿⠿⠿⠿⠿⠿⠟⠛⠛⢉⣉⣤⣤⣴⣶⣾⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣷⣤⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿",
            "⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣶⣶⣶⣶⣶⣶⣶⣶⣾⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿",
        };
        public static string[] Dragon = new string[]
        {
            "⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⡿⢟⣩⣶⣾⣿⣿⢣⣿⣿⣿⣿⠟⣫⣴⣶⣿⣿⣿⣿⣿⣿⣿⢟⣵⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿",
            "⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⡿⠟⣡⣶⣿⣿⣿⣿⡿⢣⣾⣿⠟⣫⣴⣿⣿⣿⣿⣿⣿⣿⣿⠟⣫⣴⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿",
            "⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⢏⣤⠹⣿⣿⣿⣿⣿⠟⣁⡭⢉⣵⣾⣿⣿⣿⣿⣿⣿⣿⡿⢋⣥⣾⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿",
            "⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⠟⠡⠾⢿⣷⣶⣾⣭⡭⠁⢂⢩⣶⣿⣿⣿⡟⣽⣿⣿⣿⠟⣡⣘⠻⢿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿",
            "⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⠿⣛⣥⣶⡶⠿⣿⣿⣿⠟⣡⣶⣿⣿⣧⡻⣿⣿⣿⢷⣿⣿⠟⣡⣾⣿⣿⣿⣶⣌⡛⢿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿",
            "⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⡿⢋⠰⢛⣵⣾⣿⢟⣥⢀⣾⣿⠿⢁⠚⣻⣿⣿⣿⣿⣿⣶⣝⠡⠾⠿⠋⢼⣿⣿⣿⣿⣿⣿⠿⢟⣂⣭⣵⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿",
            "⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⡿⣱⣿⣴⣿⣿⡟⣡⣿⣿⣬⣭⣶⡿⢁⣾⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⡿⠇⠾⠿⣛⣋⣭⣥⣶⣾⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿",
            "⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⢱⢿⣿⣿⢟⣥⣾⣿⣿⣿⣿⣿⣿⢧⣾⣿⣿⣿⡟⣸⣿⡿⣿⡿⢟⣫⣴⣿⢠⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿",
            "⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⢃⣴⣿⡟⣱⣿⣿⣿⣿⣿⣿⠿⢛⣥⣿⣿⣿⣿⣿⠀⣭⣿⣿⣌⠻⣿⣿⣿⡏⢾⣿⣿⣿⣿⣿⣿⣿⣿⡿⣋⣵⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿",
            "⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⢸⣿⣿⢱⣿⣿⣿⠟⠉⠁⢀⠀⡟⣼⣿⣿⣿⣿⣿⣇⢻⣿⣿⣿⣧⢹⣿⣿⣷⡸⣿⣿⣿⣿⡿⢟⣫⣵⣾⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿",
            "⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⡿⢋⣼⣿⣿⣸⣿⣿⠏⠀⠸⠌⠘⣠⣼⣿⣿⣿⣿⣿⡿⢋⣼⣿⣿⣿⡏⣸⣿⣿⣿⣧⡻⢟⣫⣕⢾⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿",
            "⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⠿⣿⡏⣴⣿⣿⣿⣿⣿⣿⣯⣶⣶⡖⣠⣾⣿⣿⡟⣉⣭⢩⡍⣰⣿⣿⣿⣿⣿⡇⣛⣫⡹⣿⣿⡗⣸⣿⣿⣦⡻⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿",
            "⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⢃⡆⠫⣾⣿⣿⣿⣿⣿⣿⣿⣿⣿⡟⣼⣿⣿⣿⡟⠠⡝⣿⡇⣱⣿⣿⣿⣿⣿⣿⢱⣿⠿⢓⣨⣉⠴⣿⣿⣿⣿⣷⡜⢿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿",
            "⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⠟⣥⢸⠿⢃⣾⣿⣿⣿⣿⣿⠟⣛⣿⣿⣧⣿⣿⣿⠟⣰⣿⢻⡌⢡⣿⣿⣿⣿⣿⣿⡏⢸⢧⣾⣿⣿⣿⣷⣜⢿⣿⣿⣿⣿⣎⢻⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿",
            "⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⡟⣸⣿⣷⣿⣿⠟⣹⣿⣿⡿⣡⡾⠛⠛⠛⣛⣛⣩⣥⣄⡉⠻⣏⠏⣼⣿⣿⣿⣿⣿⣿⡇⣾⣸⣿⣿⣿⣿⣿⣿⣦⠻⣿⣿⣿⣿⣧⢻⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿",
            "⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣇⢻⣿⣿⣿⣯⣾⣿⣿⣿⠟⠉⡀⠲⢀⠰⠿⢛⣛⣭⣭⣭⣷⣆⠀⣿⣿⣿⣿⣿⣿⣿⡧⠀⣛⣛⣫⣭⣭⣭⣭⣛⡃⣻⣿⣿⣿⣿⣇⢿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿",
            "⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣦⡙⠻⠿⠿⠿⠿⠛⠁⣤⡠⣅⣹⠏⣡⣾⣿⣿⣿⣿⠿⠿⠿⢀⣿⣿⣿⣿⣿⣿⠟⢡⣾⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣎⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿",
            "⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣧⠀⠀⠀⠂⠘⠀⣝⢧⢻⡏⣼⣿⣿⣿⡿⢛⣛⣛⣻⡃⠸⣿⣿⣿⣿⡿⣡⣾⣶⣝⠻⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿",
            "⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣾⣿⣿⣿⣶⣷⢸⣿⣿⣿⢀⢺⣿⣿⡿⠇⠀⣿⣿⣿⢋⣴⣿⣿⣿⣿⣷⣌⢻⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿",
            "⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⠇⣿⡿⠋⠈⠈⣿⣿⠇⠲⢰⣿⣿⢃⣾⣿⣿⣿⣿⣿⣿⣿⣧⠙⢿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿",
            "⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⠿⠟⣛⣩⣥⠴⢞⣫⣴⣿⡷⠀⣿⡿⠤⠃⢸⣿⡇⣾⣿⣿⣿⣿⣿⣿⣿⣿⣿⡇⣎⢿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿",
            "⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⡿⢋⠅⣒⣫⣭⣵⠶⢸⣿⣿⠻⠟⠁⠀⣻⠿⡔⢂⣿⡿⣸⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⡇⣿⣎⢻⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿",
            "⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⠰⣄⠿⠿⠿⠛⢁⣴⢿⣿⣿⣦⠰⢀⠓⠙⠿⢂⣾⣿⢡⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⢇⣿⣿⡎⢿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿",
            "⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣦⣙⣛⣛⣒⣂⣠⣴⣾⣿⣿⣿⣆⡲⢶⣶⣾⣿⣿⠇⣾⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⡏⣼⣿⣿⣿⡌⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿",
            "⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣶⣶⣶⣶⣶⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⠟⣴⣿⣿⣿⣿⣇⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿",
            "⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⠟⣴⣿⣿⣿⣿⣿⣿⣿⣇⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿",
            "⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⠟⣴⣿⣿⣿⣿⣿⣿⣿⣿⣿⣇⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿",
        };
        public static string[] ScreenBackground = new string[]
        {
                "                                                                                                                                                            " ,
                "                                                                                                                                                            " ,
                "                                                                                                                                                            " ,
                "                                                                                                                                                            " ,
                "                                                                                                                                                            " ,
                "                                                                                                                                                            " ,
                "                                                                                                                                                            " ,
                "                                                                                                                                                            " ,
                "                                                                                                                                                            " ,
                "                                                                                                                                                            " ,
                "                                                                                                                                                            " ,
                "                                                                                                                                                            " ,
                "                                                                                                                                                            " ,
                "                                                                                                                                                            " ,
                "                                                                                                                                                            " ,
                "                                                                                                                                                            " ,
                "                                                                                                                                                            " ,
                "                                                                                                                                                            " ,
                "                                                                                                                                                            " ,
                "                                                                                                                                                            " ,
                "                                                                                                                                                            " ,
                "                                                                                                                                                            " ,
                "                                                                                                                                                            " ,
                "                                                                                                                                                            " ,
                "                                                                                                                                                            " ,
                "                                                                                                                                                            " ,
                "                                                                                                                                                            " ,
                "                                                                                                                                                            " ,
                "                                                                                                                                                            " ,
                "                                                                                                                                                            " ,
                "                                                                                                                                                            " ,
                "                                                                                                                                                            " ,
                "                                                                                                                                                            " ,
                "                                                                                                                                                            " ,
                "                                                                                                                                                            " ,
                "                                                                                                                                                            " ,
                "                                                                                                                                                            " ,
                "                                                                                                                                                            " ,
                "                                                                                                                                                            " ,
                "                                                                                                                                                            " ,
                "                                                                                                                                                            " ,
                "                                                                                                                                                            " ,
                "                                                                                                                                                            " ,
                "                                                                                                                                                            " ,
                "                                                                                                                                                            "
        };

        public static string InfoEraser =
                "                                                                                                                                              ";

        public static string[] GameEraser = new string[]
            {
                "                                                                                                          " ,
                "                                                                                                          " ,
                "                                                                                                          " ,
                "                                                                                                          " ,
                "                                                                                                          " ,
                "                                                                                                          " ,
                "                                                                                                          " ,
                "                                                                                                          " ,
                "                                                                                                          " ,
                "                                                                                                          " ,
                "                                                                                                          " ,
                "                                                                                                          " ,
                "                                                                                                          " ,
                "                                                                                                          " ,
                "                                                                                                          " ,
                "                                                                                                          " ,
                "                                                                                                          " ,
                "                                                                                                          " ,
                "                                                                                                          " ,
                "                                                                                                          " ,
                "                                                                                                          " ,
                "                                                                                                          " ,
                "                                                                                                          " ,
                "                                                                                                          " ,
                "                                                                                                          " ,
                "                                                                                                          " ,
                "                                                                                                          " ,
            };
        public static string[] BottomScreenEraser = new string[]
        {
                "                                                                                                                                                            " ,
                "                                                                                                                                                            " ,
                "                                                                                                                                                            " ,
                "                                                                                                                                                            " ,
                "                                                                                                                                                            " ,
                "                                                                                                                                                            " ,
                "                                                                                                                                                            " ,
                "                                                                                                                                                            " ,
                "                                                                                                                                                            " ,
                "                                                                                                                                                            " ,
                "                                                                                                                                                            " ,
                "                                                                                                                                                            " ,
                "                                                                                                                                                            "
        };
        public static string[] ActionEraser = new string[]
        {
                "                                                                                                                                              ",
                "                                                                                                                                              ",
                "                                                                                                                                              ",
                "                                                                                                                                              ",
                "                                                                                                                                              ",
        };
    }
}
