﻿using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;
using System;
using System.Collections.Generic;

namespace Excubo.Blazor.TreeViews.__Internal
{
    public class OrderedListBase<T> : ComponentBase
    {
        [CascadingParameter] protected TreeView<T> TreeView { get; set; }
        [CascadingParameter] protected AsyncTreeView<T> AsyncTreeView { get; set; }
        protected RenderFragment<ItemContent<T>> ItemTemplate => TreeView.ItemTemplate;
        protected Func<IEnumerable<T>, IEnumerable<T>> FilterBy => TreeView.FilterBy;
        protected Func<IEnumerable<T>, IEnumerable<T>> SortBy => TreeView.SortBy;
        [Parameter] public int Level { get; set; }
        [Parameter] public bool Collapsed { get; set; }
        protected override void BuildRenderTree(RenderTreeBuilder builder)
        {
            base.BuildRenderTree(builder);
        }
    }
}
