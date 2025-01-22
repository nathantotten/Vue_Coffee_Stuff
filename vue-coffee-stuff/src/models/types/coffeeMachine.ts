export type EspressoMachine = {
    manufacturer: string,
    model: string,
    boilerType: BoilerType,
    price: number,
    year: number
}

export enum BoilerType {
    SingleBoiler = "single boiler",
    Thermocoil = "thermocoil",
    Thermoblock = "thermoblock",
    HeatExchanger = "heat exchanger",
    DualBoiler = "dual boiler",
}
  