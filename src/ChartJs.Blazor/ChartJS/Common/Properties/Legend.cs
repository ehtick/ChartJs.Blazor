﻿using ChartJs.Blazor.ChartJS.Common.Enums;
using ChartJs.Blazor.ChartJS.Common.Handlers;
using ChartJs.Blazor.Interop;

namespace ChartJs.Blazor.ChartJS.Common.Properties
{
    /// <summary>
    /// The chart legend displays data about the datasets that are appearing on the chart.
    /// <para>Link: http://www.chartjs.org/docs/latest/configuration/legend.html </para>
    /// </summary>
    public class Legend
    {
        /// <summary>
        /// Determines if the legend is displayed
        /// </summary>
        public bool Display { get; set; } = true;

        /// <summary>
        /// Position of the legend
        /// </summary>
        public Position Position { get; set; } = Position.Top;

        /// <summary>
        /// Marks that this box should take the full width of the canvas (pushing down other boxes). This is unlikely to need to be changed in day-to-day use.
        /// </summary>
        public bool FullWidth { get; set; } = true;

        /// <summary>
        /// The callback that is called when a click event is registered on a label item.
        /// <para>See <see cref="JavascriptHandler{T}"></see> and <see cref="DelegateHandler{T}"></see>.</para>
        /// </summary>
        public IMethodHandler<LegendItemMouseEvent> OnClick { get; set; }

        /// <summary>
        /// The callback that is called when a 'mousemove' event is registered on top of a label item
        /// <para>See <see cref="JavascriptHandler{T}"></see> and <see cref="DelegateHandler{T}"></see>.</para>
        /// </summary>
        public IMethodHandler<LegendItemMouseEvent> OnHover { get; set; }

        /// <summary>
        /// Legend will show datasets in reverse order.
        /// </summary>
        public bool Reverse { get; set; } = false;

        /// <summary>
        /// Configuration options for the legend-labels
        /// </summary>
        public LegendLabels Labels { get; set; } = new LegendLabels();
    }
}