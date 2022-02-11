function lowestPricesInCities(arrayOfData) {
    let arrayWithProducts = [];
    for (let string of arrayOfData) {
        let [ townName, productName, productPrice ] = string.split(' | ');
        let productObject = {
            product: productName,
            productPrice: Number(productPrice),
            townName
        }

        if (!arrayWithProducts.some(p => p.product === productName)) {
            arrayWithProducts.push(productObject);
        }

        let productForCompare = arrayWithProducts.find(p => p.product === productName);
        if (productPrice < productForCompare.productPrice) {
            productForCompare.productPrice = productPrice;
            productForCompare.townName = townName;
        }
    }

    for (let product of arrayWithProducts) {
        console.log(`${product.product} -> ${product.productPrice} (${product.townName})`);
    }
}
lowestPricesInCities(['Sample Town | Sample Product | 1000',
'Sample Town | Orange | 2',
'Sample Town | Peach | 1',
'Sofia | Orange | 3',
'Sofia | Peach | 2',
'New York | Sample Product | 1000.1',
'New York | Burger | 10']
);