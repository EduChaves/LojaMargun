import { Category } from "./Category";

export class Product{
    id!: number;
    name!: string;
    length!: string;
    image!: File;
    value!: number;
    categoryId!: number;
    category!: Category;
}