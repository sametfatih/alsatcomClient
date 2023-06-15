$('.input-cart-number').on('keyup change', function () {
    $t = $(this);

    if ($t.val().length > 3) {
        $t.next().focus();
    }

    var card_number = '';
    $('.input-cart-number').each(function () {
        card_number += $(this).val() + ' ';
        if ($(this).val().length == 4) {
            $(this).next().focus();
        }
    })

    $('.credit-card-box .number').html(card_number);
});

$('#card-holder').on('keyup change', function () {
    $t = $(this);
    $('.credit-card-box .card-holder div').html($t.val());
});

$('#card-holder').on('keyup change', function () {
    $t = $(this);
    $('.credit-card-box .card-holder div').html($t.val());
});

$('#card-expiration-month, #card-expiration-year').change(function () {
    m = $('#card-expiration-month option').index($('#card-expiration-month option:selected'));
    m = (m < 10) ? '0' + m : m;
    y = $('#card-expiration-year').val().substr(2, 2);
    $('.card-expiration-date div').html(m + '/' + y);
})

$('#card-ccv').on('focus', function () {
    $('.credit-card-box').addClass('hover');
}).on('blur', function () {
    $('.credit-card-box').removeClass('hover');
}).on('keyup change', function () {
    $('.ccv div').html($(this).val());
});


/*--------------------
CodePen Tile Preview
--------------------*/
setTimeout(function () {
    $('#card-ccv').focus().delay(1000).queue(function () {
        $(this).blur().dequeue();
    });
}, 500);

function getCreditCardType(accountNumber) {
    const svglogo1 = document.querySelector('#svglogo1');
    const svglogo2 = document.querySelector('#svglogo2');
    const logo1 = document.createElement("img");
    const logo2 = document.createElement("img");
  if (/^5[1-5]/.test(accountNumber)) {
      result = 'mastercard';
      svglogo1.removeChild(svglogo1.firstChild);
      svglogo2.removeChild(svglogo2.firstChild);

      logo1.style.width = '60px';
      logo1.style.height = '60px';
      logo1.src = '../user/images/payment/mastercard.svg';
      logo2.style.width = '60px';
      logo2.style.height = '60px';
      logo2.src = '../user/images/payment/mastercard.svg';

      svglogo1.appendChild(logo1);
      svglogo2.appendChild(logo2);
  } else if (/^4/.test(accountNumber)) {
      result = 'visa';
      svglogo1.removeChild(svglogo1.firstChild);
      svglogo2.removeChild(svglogo2.firstChild);
      
      logo1.style.width = '60px';
      logo1.style.height = '60px';
      logo1.src = '../user/images/payment/visa.svg';
      logo2.style.width = '60px';
      logo2.style.height = '60px';
      logo2.src = '../user/images/payment/visa.svg';

      svglogo1.appendChild(logo1);
      svglogo2.appendChild(logo2);
  } else if ( /^(5018|5020|5038|6304|6759|676[1-3])/.test(accountNumber)) {
      result = 'maestro';
      svglogo1.removeChild(svglogo1.firstChild);
      svglogo2.removeChild(svglogo2.firstChild);

      logo1.style.width = '60px';
      logo1.style.height = '60px';
      logo1.src = '../user/images/payment/maestro.svg';
      logo2.style.width = '60px';
      logo2.style.height = '60px';
      logo2.src = '../user/images/payment/maestro.svg';

      svglogo1.appendChild(logo1);
      svglogo2.appendChild(logo2);
  } else {
    result = 'unknown'
  }
  return result;
}

$('#card-number').change(function(){
  console.log(getCreditCardType($(this).val()));
})