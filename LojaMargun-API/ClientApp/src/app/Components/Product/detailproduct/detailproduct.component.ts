import { Component, OnInit } from '@angular/core';
import { FormControl } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';
import { LocationResponse } from 'src/app/Models/LocationResponse';
import { Product } from 'src/app/Models/Product';
import { ProductService } from 'src/app/Services/product.service';

@Component({
  selector: 'app-detailproduct',
  templateUrl: './detailproduct.component.html',
  styleUrls: ['./detailproduct.component.css']
})
export class DetailProductComponent implements OnInit {
  product!: Product;
  location!: LocationResponse;
  freightCalculate = new FormControl();

  constructor(
    private route: ActivatedRoute,
    private productService: ProductService,
    private router: Router,
  ) { }

  ngOnInit(): void {
    var productId = this.route.snapshot.params.id;
    this.productService.GetProduct(productId).subscribe(result => this.product = result);
  }

  FindLocation(){
    this.productService.GetLocation(this.freightCalculate.value).subscribe(result => this.location = result);
  }
}
