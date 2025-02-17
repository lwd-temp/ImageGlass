﻿/*
ImageGlass Project - Image viewer for Windows
Copyright (C) 2010 - 2025 DUONG DIEU PHAP
Project homepage: https://imageglass.org

This program is free software: you can redistribute it and/or modify
it under the terms of the GNU General Public License as published by
the Free Software Foundation, either version 3 of the License, or
(at your option) any later version.

This program is distributed in the hope that it will be useful,
but WITHOUT ANY WARRANTY; without even the implied warranty of
MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
GNU General Public License for more details.

You should have received a copy of the GNU General Public License
along with this program.  If not, see <https://www.gnu.org/licenses/>.
*/


using ImageGlass.UI;

namespace ImageGlass.Settings;

public class RequestUpdatingThemeEventArgs(IgTheme theme, bool handled = false)
{
    /// <summary>
    /// Gets the theme pack.
    /// </summary>
    public IgTheme Theme { get; } = theme;


    /// <summary>
    /// Gets, sets value indicates that the event is already handled.
    /// </summary>
    public bool Handled { get; set; } = handled;
}
