$(document).ready(function(){

  $(window).scroll(function(){
    if($(this).scrollTop() > 40){
      $('#topBtn').fadeIn();
    } else{
      $('#topBtn').fadeOut();
    }
  });

  $("#topBtn").click(function(){
    $('html ,body').animate({scrollTop : 0},800);
  });
});

$(document).ready(function() {
 
/* Set rates + misc */
var taxRate = 0.05;
var shippingRate = 15.00; 
var fadeTime = 300;
 
 
/* Assign actions */
$('.product-quantity input').change( function() {
  updateQuantity(this);
});
 
$('.product-removal button').click( function() {
  removeItem(this);
});
 
 
/* Recalculate cart */
function recalculateCart()
{
  var subtotal = 0;
   
  /* Sum up row totals */
  $('.product').each(function () {
    subtotal += parseFloat($(this).children('.product-line-price').text());
  });
   
  /* Calculate totals */
  var tax = subtotal * taxRate;
  var shipping = (subtotal > 0 ? shippingRate : 0);
  var total = subtotal + tax + shipping;
   
  /* Update totals display */
  $('.totals-value').fadeOut(fadeTime, function() {
    $('#cart-subtotal').html(subtotal.toFixed(2));
    $('#cart-tax').html(tax.toFixed(2));
    $('#cart-shipping').html(shipping.toFixed(2));
    $('#cart-total').html(total.toFixed(2));
    if(total == 0){
      $('.checkout').fadeOut(fadeTime);
    }else{
      $('.checkout').fadeIn(fadeTime);
    }
    $('.totals-value').fadeIn(fadeTime);
  });
}
 
 
/* Update quantity */
function updateQuantity(quantityInput)
{
  /* Calculate line price */
  var productRow = $(quantityInput).parent().parent();
  var price = parseFloat(productRow.children('.product-price').text());
  var quantity = $(quantityInput).val();
  var linePrice = price * quantity;
   
  /* Update line price display and recalc cart totals */
  productRow.children('.product-line-price').each(function () {
    $(this).fadeOut(fadeTime, function() {
      $(this).text(linePrice.toFixed(2));
      recalculateCart();
      $(this).fadeIn(fadeTime);
    });
  });  
}
 
 
/* Remove item from cart */
function removeItem(removeButton)
{
  /* Remove row from DOM and recalc cart total */
  var productRow = $(removeButton).parent().parent();
  productRow.slideUp(fadeTime, function() {
    productRow.remove();
    recalculateCart();
  });
}
 
});
 
 $(function(){
  $(window).scroll(function(){

    if($('body').scrollTop()>300) {
      $('.logo').addClass('chucam');
      $('.nutlen').addClass('hienthi')

    }
    else if($('body').scrollTop()<=100) {
      $('.logo').removeClass('chucam');
      $('.nutlen').removeClass('hienthi')
    }
  })


  $('.nutlen').click(function(){
    $('body').animate({'scrollTop':0});
     
  })
})  
 
 
 $(function(){
  $(window).scroll(function(){

    if($('body').scrollTop()>300) {
      $('.logo').addClass('chucam');
      $('.nutlen').addClass('hienthi')

    }
    else if($('body').scrollTop()<=100) {
      $('.logo').removeClass('chucam');
      $('.nutlen').removeClass('hienthi')
    }
  })


  $('.nutlen').click(function(){
    $('body').animate({'scrollTop':0});
     
  })
})  
 
$(function() {
  console.log('tinh thu vi tri ham .offser().top');
  console.log($('.top').offset().top);


  $('.sidebar ul li:id1 a').on('click', function(event) {
    event.preventDefault();
    $('body').animate({scrollTop: $('.top').offset().top},900);

  });
});
