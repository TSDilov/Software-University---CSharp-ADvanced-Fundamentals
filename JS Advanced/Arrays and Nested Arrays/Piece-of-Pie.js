function pieceOfPie(allPies, fromFirstPie, toSecondPie) {
    let firstPieIndex = allPies.indexOf(fromFirstPie);
    let secondPieIndex = allPies.indexOf(toSecondPie);
    let pieceOfPiesArray = allPies.slice(firstPieIndex, secondPieIndex + 1);
    return pieceOfPiesArray
}
console.log(pieceOfPie(['Pumpkin Pie',
'Key Lime Pie',
'Cherry Pie',
'Lemon Meringue Pie',
'Sugar Cream Pie'],
'Key Lime Pie',
'Lemon Meringue Pie'
));