    $(document).ready(function () {
        'use strict';
        $("input").keyup(function () {
            if ($(this).hasClass("ann_rate_class_1")) {
                var float = /^\s*(\+|-)?((\d+(\.\d+)?)|(\.\d+))\s*$/;
                var amp_filled = parseFloat($(".amp_filled").text().replace("%", ""));
                var amp_unfilled = parseFloat($(".amp_unfilled").text().replace("%", ""));
                if($(this).val().match(/^\d+$/) || float.test($(this).val())) {
                    $(this).parent().next().children("input").prop("checked", true);
                    var ann_rate = parseFloat($(this).val());
                    var result = (ann_rate * (amp_filled / 100)) + (ann_rate * (amp_unfilled / 100));
                    $(this).parent().next().next().text("$" + result.toFixed(2));
                    var total = ann_rate + result;
                    $(this).parent().next().next().next().text("$" + total.toFixed(2));
                }
                else {
                    $(this).parent().next().children("input").prop("checked", false);
                    $(this).parent().next().next().next().text("$0");
                    $(this).parent().next().next().text("0");
                }
                var ann_rate_total = 0;
                var amp_total = 0;
                $(".ann_rate_class_1").each(function() {
                    if($(this).val().match(/^\d+$/)  || float.test($(this).val())) {
                        ann_rate_total += parseFloat($(this).val());
                    }
                    amp_total += parseFloat($(this).parent().next().next().next().text().replace("$", ""));
                });
                ann_rate_total *= 0.03;
                $(this).parent().parent().siblings().each(function() {
                    if($(this).find(".ann_rate_total_class_1").length) {
                        if(ann_rate_total == 0) {
                            $(this).find(".ann_rate_total_class_1").next().children("input").prop("checked", false);
                            $(this).find(".ann_rate_total_class_1").text("0");
                            $(this).find(".ann_rate_total_class_1").next().next().text("0");
                            $(this).find(".ann_rate_total_class_1").next().next().next().text("$0");
                            if(amp_total == 0) {
                                $(this).find(".ann_rate_total_class_1").parent().next().children().last().text("$0");
                            }
                            else {
                                $(this).find(".ann_rate_total_class_1").parent().next().children().last().text("$" + amp_total.toFixed(2));
                            }
                            return false;
                        }
                        else {
                            $(this).find(".ann_rate_total_class_1").next().children("input").prop("checked", true);
                            $(this).find(".ann_rate_total_class_1").text("$" + ann_rate_total.toFixed(2));
                            var benefits = (ann_rate_total * (amp_filled / 100)) + (ann_rate_total * (amp_unfilled / 100));
                            $(this).find(".ann_rate_total_class_1").next().next().text("$" + benefits.toFixed(2));
                            amp_total += ann_rate_total + benefits;
                            $(this).find(".ann_rate_total_class_1").parent().next().children().last().text("$" + amp_total.toFixed(2));
                            $(this).find(".ann_rate_total_class_1").next().next().next().text("$" + (ann_rate_total + benefits).toFixed(2));
                            return false;
                        }
                    }
                });
            }
            else if($(this).hasClass("ann_rate_class_2")) {
                var float= /^\s*(\+|-)?((\d+(\.\d+)?)|(\.\d+))\s*$/;
                var sp_filled = parseFloat($(".sp_filled").text().replace("%", ""));
                var sp_unfilled = parseFloat($(".sp_unfilled").text().replace("%", ""));
                if($(this).val().match(/^\d+$/) || float.test($(this).val())) {
                    $(this).parent().next().children("input").prop("checked", true);
                    var ann_rate = parseFloat($(this).val());
                    var result = (ann_rate * (sp_filled / 100)) + (ann_rate * (sp_unfilled / 100));
                    $(this).parent().next().next().text("$" + result.toFixed(2));
                    var total = ann_rate + result;
                    $(this).parent().next().next().next().text("$" + total.toFixed(2));
                }
                else {
                    $(this).parent().next().children("input").prop("checked", false);
                    $(this).parent().next().next().next().text("$0");
                    $(this).parent().next().next().text("0");
                }
                var ann_rate_total = 0;
                var sp_total = 0;
                $(".ann_rate_class_2").each(function() {
                    if($(this).val().match(/^\d+$/)  || float.test($(this).val())) {
                        ann_rate_total += parseFloat($(this).val());
                    }
                    sp_total += parseFloat($(this).parent().next().next().next().text().replace("$", ""));
                });
                ann_rate_total *= 0.03;
                $(this).parent().parent().siblings().each(function() {
                    if($(this).find(".ann_rate_total_class_2").length) {
                        if(ann_rate_total == 0) {
                            $(this).find(".ann_rate_total_class_2").next().children("input").prop("checked", false);
                            $(this).find(".ann_rate_total_class_2").text("0");
                            $(this).find(".ann_rate_total_class_2").next().next().text("0");
                            $(this).find(".ann_rate_total_class_2").next().next().next().text("$0");
                            if(sp_total == 0) {
                                $(this).find(".ann_rate_total_class_2").parent().next().children().last().text("$0");
                            }
                            else {
                                $(this).find(".ann_rate_total_class_2").parent().next().children().last().text("$" + sp_total.toFixed(2));
                            }
                            return false;
                        }
                        else {
                            $(this).find(".ann_rate_total_class_2").next().children("input").prop("checked", true);
                            $(this).find(".ann_rate_total_class_2").text("$" + ann_rate_total.toFixed(2));
                            var benefits = (ann_rate_total * (sp_filled / 100)) + (ann_rate_total * (sp_unfilled / 100));
                            $(this).find(".ann_rate_total_class_2").next().next().text("$" + benefits.toFixed(2));
                            sp_total += ann_rate_total + benefits;
                            $(this).find(".ann_rate_total_class_2").parent().next().children().last().text("$" + sp_total.toFixed(2));
                            $(this).find(".ann_rate_total_class_2").next().next().next().text("$" + (ann_rate_total + benefits).toFixed(2));
                            return false;
                        }
                    }
                });
            }
            var total_salaries = 0;
            var total_salaries_tmp_1 = parseFloat($(".ann_rate_total_class_1").first().parent().next().children().last().text().replace("$", ""));
            var total_salaries_tmp_2 = parseFloat($(".ann_rate_total_class_2").first().parent().next().children().last().text().replace("$", ""));
            if(total_salaries_tmp_1 != 0) {
                total_salaries += total_salaries_tmp_1;
            }
            if(total_salaries_tmp_2 != 0) {
                total_salaries += total_salaries_tmp_2;
            }
            if(total_salaries == 0) {
                $(".total_salaries").val("");
            }
            else {
                $(".total_salaries").val("$" + total_salaries.toFixed(2));
            }
        });
    });