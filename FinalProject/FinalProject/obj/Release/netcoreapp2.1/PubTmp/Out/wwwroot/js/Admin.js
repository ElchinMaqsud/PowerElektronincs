$(document).ready(function () {

    $(document).on("change", "#category-for-create-model", function () {


        var categoryId = $(this).val();
        if (categoryId) {
            $.ajax({
                url: "/PowerAdmin/AdminAjax/SelectMarks?id=" + categoryId,
                type: "get",
                success: function (res) {
                    $("#mark-for-create-model").html(res);
                }
            })
        }
    });





});