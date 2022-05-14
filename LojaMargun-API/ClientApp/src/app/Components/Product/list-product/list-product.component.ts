import { Component, OnInit } from '@angular/core';
import { Product } from 'src/app/Models/Product';
import { ProductService } from 'src/app/Services/product.service';

@Component({
  selector: 'app-list-product',
  templateUrl: './list-product.component.html',
  styleUrls: ['./list-product.component.css']
})
export class ListProductComponent implements OnInit {
 products: Product[] = [];

  constructor(private productService: ProductService) { }

  ngOnInit(): void {
      this.productService.GetAllProducts().subscribe(result => result.forEach(value => this.products.push(value)));
  }

}
