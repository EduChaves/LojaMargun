import { Category } from "./Category";

export class Product {
    id!: number;
    name!: string;
    length!: string;
    image!: string;
    value!: number;
    category!: Category;
    categoryId!: number;
}