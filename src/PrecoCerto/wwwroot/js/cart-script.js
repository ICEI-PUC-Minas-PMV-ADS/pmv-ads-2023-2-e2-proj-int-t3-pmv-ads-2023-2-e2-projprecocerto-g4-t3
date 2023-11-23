// wwwroot/js/cart-script.js

$(document).ready(function () {
    function updateCartItem(parent) {
        // Obtém a quantidade atual e converte para um número
        var qtyInput = parent.find(".qty-input");
        var currentQty = parseInt(qtyInput.val()) || 0;

        // Obtém o texto do preço unitário do produto
        var unitPriceText = parent.find(".price").text().trim();

        // Extrai apenas os dígitos do preço
        var unitPriceDigits = unitPriceText.replace(/[^\d,.-]/g, '');

        // Converte para um número
        var unitPrice = parseFloat(unitPriceDigits.replace(",", ".")) || 0;

        // Calcula e atualiza o preço total
        var totalPrice = unitPrice * currentQty;

        // Atualiza o preço total na interface
        parent.find(".subtotal h5").text(totalPrice.toLocaleString('pt-BR', { style: 'currency', currency: 'BRL' }));

        // Atualiza o valor total na página do carrinho
        updateCartTotal();
    }

    function updateCartTotal() {
        // Atualiza o valor total do carrinho na interface
        var cartTotal = 0;

        $(".cart-item").each(function () {
            var qtyInput = $(this).find(".qty-input");
            var currentQty = parseInt(qtyInput.val()) || 0;

            var unitPriceText = $(this).find(".price").text().trim();
            var unitPriceDigits = unitPriceText.replace(/[^\d,.-]/g, '');
            var unitPrice = parseFloat(unitPriceDigits.replace(",", ".")) || 0;

            cartTotal += unitPrice * currentQty;
        });

        // Atualiza o valor total na página do carrinho
        $(".total h4").text(cartTotal.toLocaleString('pt-BR', { style: 'currency', currency: 'BRL' }));

        // Atualiza o valor total abaixo
        $(".list-total .price").text(cartTotal.toLocaleString('pt-BR', { style: 'currency', currency: 'BRL' }));

        // Atualiza o valor subtotal abaixo
        $(".subtotal .price").text(cartTotal.toLocaleString('pt-BR', { style: 'currency', currency: 'BRL' }));
    }

    // Manipula o evento de clique nos botões de incremento e decremento
    $(".qty-left-minus, .qty-right-plus").on("click", function () {
        var parent = $(this).closest(".cart-item");

        // Obtém a quantidade atual e converte para um número
        var qtyInput = parent.find(".qty-input");
        var currentQty = parseInt(qtyInput.val()) || 0;

        // Atualiza a quantidade com base no botão clicado
        if ($(this).data("type") === "minus" && currentQty > 1) {
            qtyInput.val(currentQty - 1);
        } else if ($(this).data("type") === "plus") {
            qtyInput.val(currentQty + 1);
        }

        // Atualiza o preço total do item
        updateCartItem(parent);
    });

    // Chama a função para atualizar o valor total inicialmente
    updateCartTotal();
});
