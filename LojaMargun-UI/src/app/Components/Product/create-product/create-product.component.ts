import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { ProductService } from 'src/app/Services/product.service';

@Component({
  selector: 'app-create-product',
  templateUrl: './create-product.component.html',
  styleUrls: ['./create-product.component.css']
})
export class CreateProductComponent implements OnInit {
  form: any;
  errors: string[] = [];

  constructor(private productService: ProductService) { }

  ngOnInit(): void {
    this.form = new FormGroup({
      name: new FormControl(null, [Validators.required, Validators.minLength(3), Validators.maxLength(50)]),
      length: new FormControl(null, [Validators.required, Validators.maxLength(15)]),
      image: new FormControl(null, [Validators.required]),
      category: new FormControl(null, [Validators.required])
    });
  }

  get Controls(){
    return this.form.controls;
  }

  FormSubmit(){
    const data = this.form.value;
    this.productService.Add(data).subscribe(result => console.log(result));
  }
}
