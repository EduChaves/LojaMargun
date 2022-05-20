import { Component, OnInit } from '@angular/core';
import { FormControl } from '@angular/forms';
import { Observable } from 'rxjs';
import { Product } from 'src/app/Models/Product';
import { ProductService } from 'src/app/Services/product.service';
import {map, startWith} from 'rxjs/operators';
@Component({
  selector: 'app-list-product',
  templateUrl: './list-product.component.html',
  styleUrls: ['./list-product.component.css']
})
export class ListProductComponent implements OnInit {
 products: Product[] = [];
 findProduct =  new FormControl();
 filterOption!: Observable<Product[]>

  constructor(private productService: ProductService) { }

  ngOnInit(): void {
    this.productService.GetAllProducts().subscribe(result => result.forEach(value => this.products.push(value)));
    this.filterOption = this.findProduct.valueChanges.pipe(startWith(''), map((value:string) => this.filterProducts(value)));
  }

  filterProducts(product: string): Product[]{
    if(product.length > 3){
      return this.products.filter(value => value.name.toLowerCase().includes(product));
    }
    return [];
  }
}
