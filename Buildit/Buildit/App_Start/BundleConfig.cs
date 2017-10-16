﻿using System.Web;
using System.Web.Optimization;

namespace Buildit
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js", "~/Scripts/jquery.unobtrusive-ajax.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/moment.js",
                      "~/Scripts/bootstrap-datetimepicker.min.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new ScriptBundle("~/bundles/signalr").Include(
                      "~/Scripts/jquery.signalR*"));

            //bundles.Add(new ScriptBundle("~/bundles/ratings").Include(
            //          "~/Scripts/jquery.rateyo.js",
            //          "~/Scripts/Common/rating.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/Site.css",
                      "~/Content/bootstrap-responsive.css"));

            bundles.Add(new ScriptBundle("~/bundles/chat").Include(
                    "~/Scripts/Common/chat.js"));

            bundles.Add(new ScriptBundle("~/bundles/date").Include(
                    "~/Scripts/moment.js",
                    "~/Scripts/Common/dateTimePicker"));

        }
    }
}
