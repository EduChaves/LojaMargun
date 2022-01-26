import { Byte } from "@angular/compiler/src/util";
import { Bag } from "./Bag";
import { Category } from "./Category";

export class Product{
    id!: number;
    name!: string;
    length!: string;
    image!: Byte;
    value!: number;
    categoryId!: number;
    category!: Category;
}