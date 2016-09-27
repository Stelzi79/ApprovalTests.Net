﻿using System;
using System.Collections.Generic;

namespace ApprovalTests.Reporters
{
    public class DiffPrograms
    {
        private static Func<IEnumerable<string>> TEXT           = GenericDiffReporter.GetTextFileTypes;
        private static Func<IEnumerable<string>> IMAGE          = GenericDiffReporter.GetImageFileTypes;
        private static Func<IEnumerable<string>> TEXT_AND_IMAGE = null;
        public static class Mac
        {
            public static DiffInfo DIFF_MERGE = new DiffInfo("/Applications/DiffMerge.app/Contents/MacOS/DiffMerge",
                "%s %s --nosplash", TEXT);
            public static DiffInfo BEYOND_COMPARE = new DiffInfo("/Applications/Beyond Compare.app/Contents/MacOS/bcomp",
                TEXT);
            public static DiffInfo KALEIDOSCOPE = new DiffInfo("/Applications/Kaleidoscope.app/Contents/MacOS/ksdiff",
                TEXT_AND_IMAGE);
            public static DiffInfo KDIFF3 = new DiffInfo("/Applications/kdiff3.app/Contents/MacOS/kdiff3",
                "%s %s -m", TEXT);
            public static DiffInfo P4MERGE = new DiffInfo("/Applications/p4merge.app/Contents/MacOS/p4merge",
                TEXT_AND_IMAGE);
            public static DiffInfo TK_DIFF = new DiffInfo("/Applications/TkDiff.app/Contents/MacOS/tkdiff", TEXT);
        }
        public static class Windows
        {
            public static DiffInfo BEYOND_COMPARE_3 = new DiffInfo("C:\\Program Files\\Beyond Compare 3\\BCompare.exe",
                TEXT_AND_IMAGE);
            public static DiffInfo TORTOISE_IMAGE_DIFF = new DiffInfo(
                "C:\\Program Files\\TortoiseSVN\\bin\\TortoiseIDiff.exe", "/left:%s /right:%s", IMAGE);
            public static DiffInfo TORTOISE_TEXT_DIFF = new DiffInfo(
                "C:\\Program Files\\TortoiseSVN\\bin\\TortoiseMerge.exe", TEXT);
            public static DiffInfo WIN_MERGE_REPORTER = new DiffInfo("C:\\Program Files\\WinMerge\\WinMergeU.exe", TEXT);
        }
    }
}