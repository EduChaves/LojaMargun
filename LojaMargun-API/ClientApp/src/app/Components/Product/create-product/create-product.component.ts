import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { MatSnackBar } from '@angular/material/snack-bar';
import { Router } from '@angular/router';
import { Category } from 'src/app/Models/Category';
import { Product } from 'src/app/Models/Product';
import { CategoryService } from 'src/app/Services/category.service';
import { ProductService } from 'src/app/Services/product.service';

@Component({
  selector: 'app-create-product',
  templateUrl: './create-product.component.html',
  styleUrls: ['./create-product.component.css']
})
export class CreateProductComponent implements OnInit {
  form: any;
  image: string = "";
  formGroup!: FormGroup;
  errors: string[] = [];
  categories: Category[] = [];

  constructor(
    private categoryService: CategoryService,
    private productService: ProductService,
    private snackBar: MatSnackBar,
    private router: Router
    ) { }

  ngOnInit(): void {
    this.categoryService.GetAll().subscribe(result => result.forEach(value => this.categories.push(value)));

    this.form = new FormGroup({
      name: new FormControl(null, [Validators.required, Validators.minLength(3), Validators.maxLength(50)]),
      description: new FormControl(null, [Validators.required, Validators.minLength(5), Validators.maxLength(100)]),
      length: new FormControl(null, [Validators.required, Validators.minLength(3), Validators.maxLength(15)]),
      image: new FormControl(null, [Validators.required]),
      value: new FormControl(null, [Validators.required]),
      quantity: new FormControl(null, [Validators.required]),
      category: new FormControl(null, [Validators.required])
    });
  }

  get Controls(){
    return this.form.controls;
  }

  SelectImage(image: any) {
    const reader = new FileReader();
    reader.onload = ((value: any) => {
      document.getElementById("image")?.removeAttribute("hidden");
      document.getElementById("image")?.setAttribute("src", value.target?.result)
      console.log(value.target?.result);
      this.image = value.target?.result;
    });
    reader.readAsDataURL(image.target.files[0] as File);
  }

  SubmitForm(){
    const form = this.form.value;
    var formData = new FormData();

    formData.append("file", this.form.get("image").value);
    
    const data = new Product();
    data.name = form.name;
    data.description = form.description;
    data.length = form.length;
    data.value = form.value;
    data.image = this.image;
    data.categoryId = form.category.id;
    data.active = true;

    this.productService.AddProduct(data).subscribe(result => {
      this.router.navigate(['product/listproduct']);
      this.snackBar.open("Produto cadastrado com sucesso", "", {
        duration: 3000,
        horizontalPosition:"end",
        verticalPosition:"top"
      })
    });
  }
}