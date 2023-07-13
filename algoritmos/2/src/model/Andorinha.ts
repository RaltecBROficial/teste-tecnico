import { IVoador } from "../interface/IVoador";
import { Ave } from "./Ave";

export class Andorinha extends Ave implements IVoador {

    voar(): void {
        console.log(`Andorinha voando...`)
    }
}