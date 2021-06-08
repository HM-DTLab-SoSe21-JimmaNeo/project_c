﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEIIApp.Shared
{
    public class ModulDto
    {
        public int ModulId { get; set; }

        public List<EssayDto> Essays { get; set; }

        public List<VideoDto> Videos { get; set; }

        public List<QuizDto> Quizes { get; set; }
    }
}