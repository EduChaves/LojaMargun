import { Category } from "./Category";

export class Product{
   id!: number;
   name!: string;
   description!: string;
   length!: string;
   image!: string;
   value!: number;
   categoryId!: number;
   category!: Category;
   active!: boolean;
}