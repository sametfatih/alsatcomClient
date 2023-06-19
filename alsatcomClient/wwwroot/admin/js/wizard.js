(function ($) {
    'use strict';
    var form = $("#productAdd-form");
    form.children("div").steps({
        headerTag: "h3",
        bodyTag: "section",
        transitionEffect: "slideLeft",
        onFinished: function (event, currentIndex) {

            if ($('#TermsAndConditions').is(':checked')) {

                var formData = form.serialize();

                $.ajax({
                    type: "POST",
                    url: "/Admin/Products/ProductAdd",
                    data: formData,
                    dataType: "json",
                    encode: true,
                    success: function (data) {
                        console.log(data);
                        setTimeout(() => {
                            document.location.href = '/admin/dashboard';
                        }, 3500);

                        showSuccessToast('Ürün başarıyla eklendi.');
                    },
                    error: function () {
                        showDangerToast('Ürün eklenemedi!. Lütfen tekrar deneyiniz.');
                    }
                });
            }
            else {
                showWarningToast('Lütfen şartlar ve koşullar sözleşmesini onaylayın!.');
            }

        },
        labels: {
            cancel: "İptal",
            current: "Şuan ki adım:",
            pagination: "Sayfalama",
            finish: "Bitir",
            next: "İleri",
            previous: "Geri Dön",
            loading: "Yükleniyor ..."
        }
    });
    var validationForm = $("#example-validation-form");
    validationForm.val({
        errorPlacement: function errorPlacement(error, element) {
            element.before(error);
        },
        rules: {
            confirm: {
                equalTo: "#password"
            }
        }
    });
    validationForm.children("div").steps({
        headerTag: "h3",
        bodyTag: "section",
        transitionEffect: "slideLeft",
        onStepChanging: function (event, currentIndex, newIndex) {
            validationForm.val({
                ignore: [":disabled", ":hidden"]
            })
            return validationForm.val();
        },
        onFinishing: function (event, currentIndex) {
            validationForm.val({
                ignore: [':disabled']
            })
            return validationForm.val();
        },
        onFinished: function (event, currentIndex) {
            alert("Submitted!");
        }
    });
    var verticalForm = $("#example-vertical-wizard");
    verticalForm.children("div").steps({
        headerTag: "h3",
        bodyTag: "section",
        transitionEffect: "slideLeft",
        stepsOrientation: "vertical",
        onFinished: function (event, currentIndex) {
            alert("Başarılı!");
        },
        labels: {
            cancel: "İptal",
            current: "Şuan ki adım:",
            pagination: "Sayfalama",
            finish: "Bitir",
            next: "İleri",
            previous: "Geri Dön",
            loading: "Yükleniyor ..."
        }
    });
})(jQuery);