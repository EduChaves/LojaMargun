import { Category } from "./Category";
import { Product } from "./Product";

export class Item {
    id!: number;
    itemId!: number;
    product!: Product;
    quantity!: number;
    categoryId!: number;
    category!: Category;
}