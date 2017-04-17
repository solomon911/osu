﻿// Copyright (c) 2007-2017 ppy Pty Ltd <contact@ppy.sh>.
// Licensed under the MIT Licence - https://raw.githubusercontent.com/ppy/osu/master/LICENCE

using osu.Game.Modes.Objects.Types;

namespace osu.Game.Modes.Objects.Legacy.Mania
{
    /// <summary>
    /// Legacy Hit-type, used for parsing Beatmaps.
    /// </summary>
    internal sealed class Hit : HitObject, IHasColumn, IHasCombo
    {
        public int Column { get; set; }

        public bool NewCombo { get; set; }
    }
}
