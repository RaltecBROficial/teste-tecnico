import { IVoador } from "../interface/IVoador";
import { Ave } from "./Ave";

export class Pato extends Ave implements IVoador { 

    voar(): void {
        console.log("Pato voando...")
    }
}