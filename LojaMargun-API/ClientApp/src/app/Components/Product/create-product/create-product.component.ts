import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormControl, FormGroup, Validators } from '@angular/forms';
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
    private router: Router
    ) { }

  ngOnInit(): void {
    this.categoryService.GetAll().subscribe(result => result.forEach(value => this.categories.push(value)));

    this.form = new FormGroup({
      name: new FormControl(null, [Validators.required, Validators.minLength(3), Validators.maxLength(50)]),
      length: new FormControl(null, [Validators.required, Validators.minLength(3), Validators.maxLength(15)]),
      image: new FormControl(null, [Validators.required]),
      value: new FormControl(null, [Validators.required]),
      category: new FormControl(null, [Validators.required])
    });
  }

  get Controls(){
    return this.form.controls;
  }

  // SelectImage(image: any) {
  //   debugger
  //   this.form.get('image').setValue(image.target.files[0]);
  //   const reader = new FileReader();
  //   reader.onload = ((value: any) => {
  //     document.getElementById("image")?.removeAttribute("hidden");
  //     document.getElementById("image")?.setAttribute("src", value.target?.result)
  //   });
  //   reader.readAsDataURL(this.image);
  // }

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
    debugger
    const form = this.form.value;
    var formData = new FormData();

    formData.append("file", this.form.get("image").value);
    const data = new Product();
      data.name = form.name;
      data.length = form.length
      data.categoryId = form.category.id;
      data.value = form.value;
      data.image = this.image;

      this.productService.AddProduct(data).subscribe(result => console.log(result))

    // this.productService.SaveImage(formData).subscribe(result => {
    //   // const data = new Product();
    //   // data.name = form.name;
    //   // data.category = form.categoryId;
    //   // data.value = form.value;
    //   // data.image = this.image;

    //   // this.productService.AddProduct(data).subscribe(result => console.log(result))
    // });
  }
}