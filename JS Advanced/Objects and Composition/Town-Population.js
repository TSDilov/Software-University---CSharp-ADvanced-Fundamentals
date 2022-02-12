function townPopulation(arrayOfTowns) {
    let population = {};
    for (let i = 0; i < arrayOfTowns.length; i++) {
        let currentTownInfo = arrayOfTowns[i];
        currentTownInfo = currentTownInfo.split(' <-> ');
        currentTown = currentTownInfo[0];
        currentTownPopulation = Number(currentTownInfo[1]);
        if (!population[currentTown]) {
            population[currentTown] = 0;
        }

        population[currentTown] += currentTownPopulation;
    }

    for (let town in population) {
        console.log(`${town} : ${population[town]}`);
    }
}
townPopulation(['Istanbul <-> 100000',
'Honk Kong <-> 2100004',
'Jerusalem <-> 2352344',
'Mexico City <-> 23401925',
'Istanbul <-> 1000']
);