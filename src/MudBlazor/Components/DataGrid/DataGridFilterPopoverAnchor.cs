// Copyright (c) MudBlazor 2021
// MudBlazor licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace MudBlazor;

/// <summary>
/// Indicates how a filter popover for <see cref="MudDataGrid{T}"/> is anchored when it opens.
/// </summary>
public enum DataGridFilterPopoverAnchor
{
    /// <summary>
    /// Opens the filter popover at the current pointer position.
    /// </summary>
    /// <remarks>
    /// This is the default behavior.
    /// </remarks>
    Cursor,

    /// <summary>
    /// Opens the filter popover anchored to the filter button which triggered it.
    /// </summary>
    FilterButton
}
