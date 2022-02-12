function townsToJSON(array) {
    let towns = [];
    for (let i = 1; i < array.length; i++) {
        let arrayForCurrentTown = array[i].split('|').filter(a => a);
        towns.push({
            Town: arrayForCurrentTown[0].trim(),
            Latitude: Math.round((Number (arrayForCurrentTown[1]) + Number.EPSILON) * 100) / 100,
            Longitude: Math.round((Number (arrayForCurrentTown[2]) + Number.EPSILON) * 100) / 100
        });
    }

    return JSON.stringify(towns);
}
console.log(townsToJSON(['| Town | Latitude | Longitude |',
'| Sofia | 42.696552 | 23.32601 |',
'| Beijing | 39.913818 | 116.363625 |']
));;