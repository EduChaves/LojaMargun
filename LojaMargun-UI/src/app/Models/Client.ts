import { Bag } from "./Bag";
import { User } from "./User";

export class Client{
    id!: number;
    userId!: string;
    user!: User;
    bagId!: number;
    bag!: Bag;
}