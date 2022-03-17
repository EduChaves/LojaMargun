import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { MatSnackBar } from '@angular/material/snack-bar';
import { Category } from 'src/app/Models/Category';
import { CategoryService } from 'src/app/Services/category.service';
import { ProductService } from 'src/app/Services/product.service';

@Component({
  selector: 'app-create-product',
  templateUrl: './create-product.component.html',
  styleUrls: ['./create-product.component.css']
})
export class CreateProductComponent implements OnInit {
  form: any;
  listErrors: string[] = [];
  listCategories: Category[]; 

  constructor(
    private productService: ProductService, 
    private categoryService: CategoryService,
    private snackBar: MatSnackBar
    ) { }

  ngOnInit() {
    this.categoryService.GetAlCategories().subscribe(result => result.forEach(value => this.listCategories.push(value)));

    this.form = new FormGroup({
      name: new FormControl(null, [Validators.required, Validators.minLength(5), Validators.maxLength(50)]),
      length: new FormControl(null, [Validators.required, Validators.maxLength(15)]),
      value: new FormControl(null, [Validators.required]),
      image: new FormControl(null, [Validators.required]),
      categoryId: new FormControl(null, [Validators.required])
    });
  }

  get Controls(){
    return this.form.controls;
  }

  SelectImage(image : any){

  }

  SubmitForm(){
    this.productService.AddProduct(this.form.value).subscribe(result => console.log(result));
  }
}
