import { Client } from "./Client";

export class Sale{
    id!: number;
    bagId!: number;
    clientId!: number;
    client!: Client;
    buyDate!: Date;
    value!: number;
}