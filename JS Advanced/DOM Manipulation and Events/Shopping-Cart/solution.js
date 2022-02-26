function solve() {
   let productsSet = new Set();
   let prices = [];
   let addButtonElement = Array.from(document.getElementsByClassName('add-product'));

   for (let product of addButtonElement) {
      product.addEventListener('click', addproduct);
   }

   let checkoutElement = document.getElementsByClassName('checkout')[0];
   checkoutElement.addEventListener('click', () => {
      document.getElementsByTagName('textarea')[0].textContent 
      += `You bought ${Array.from(productsSet).join(', ')} for ${prices.reduce((a, b) => a + b, 0).toFixed(2)}.`;
      Array.from(document.getElementsByTagName('button')).forEach(el => el.disabled = true);
   })

   function addproduct(event) {
      let price = Number(event.target.parentNode.parentNode.children[3].textContent);
      let product = event.target.parentNode.parentNode.children[1].children[0].textContent;
      let messageForInput = `Added ${product} for ${price.toFixed(2)} to the cart.\n`;
      document.getElementsByTagName('textarea')[0].disabled = false;
      document.getElementsByTagName('textarea')[0].textContent += messageForInput;
      productsSet.add(product);
      prices.push(price);
   }
}