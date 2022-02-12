function storeCatalogue(arrayOfProducts) {
    let sortedProductArray = [];
    for (const product of arrayOfProducts) {
        let [productName, ProductPrice] = product.split(' : ') 
        let currentProduct = {
            productName,
            ProductPrice
        };

        sortedProductArray.push(currentProduct);
    }

    sortedProductArray = sortedProductArray.sort((a, b) => (a.productName).localeCompare(b.productName));
    let currentUpperCase = null;

    for (const product of sortedProductArray) {
        let upperCase = product.productName[0];
        if (currentUpperCase !== upperCase) {
            currentUpperCase = upperCase;
            console.log(upperCase);
        }
        console.log(`${product.productName}: ${product.ProductPrice}`);
    }
}
storeCatalogue(['Appricot : 20.4',
'Fridge : 1500',
'TV : 1499',
'Deodorant : 10',
'Boiler : 300',
'Apple : 1.25',
'Anti-Bug Spray : 15',
'T-Shirt : 10']
);