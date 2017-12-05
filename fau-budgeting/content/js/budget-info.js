function displayBudgetInfo(id) {
    $.ajax({
        url: "/api/budget-request-info",
        data: {
            id: id
        },
        success: function (response) {
            var formData = JSON.parse(response);

            $.each(formData, function (key, value) {
                $("input[name='" + key + "']").attr("value", value);
            });
        }
    });
}

function disableEditing() {
    $("input").each(function () {
        $(this).prop("readonly", true);
    });
    $("button[type='submit']").hide();
}

function enableEditing() {
    $("input").each(function () {
        $(this).prop("readonly", false);
    });
}