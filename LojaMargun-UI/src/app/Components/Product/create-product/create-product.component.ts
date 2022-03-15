import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
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
  image!: File;
  categories!: Category[];
  errors: string[] = [];

  constructor(
    private productService: ProductService,
    private categoryService: CategoryService
    ) { }

  ngOnInit(): void {
    debugger
    this.categoryService.GetAll().subscribe(result => result.forEach(value => this.categories.push(value)));

    this.form = new FormGroup({
      name: new FormControl(null, [Validators.required, Validators.minLength(3), Validators.maxLength(50)]),
      length: new FormControl(null, [Validators.required, Validators.maxLength(15)]),
      value: new FormControl(null, [Validators.required, Validators.maxLength(15)]),
      image: new FormControl(null, [Validators.required]),
      category: new FormControl(null, [Validators.required])
    });
  }

  get Controls(){
    return this.form.controls;
  }

  SelectImage(fileInput: any){
    this.image = fileInput.target.files[0] as File;
    const read = new FileReader();
    read.onload = ((value: any) => {
      document.getElementById("image")?.removeAttribute("hidden");
      document.getElementById("image")?.setAttribute("src", value.target.result)
    });
    read.readAsDataURL(this.image);
  }

  FormSubmit(){
    debugger
    const data = this.form.value;
    const formData = new FormData();

    if(this.image != null)
      formData.append('file', this.image, this.image.name)
    
      this.productService.SaveImage(formData).subscribe(result => {
        const product: Product = new Product();
        product.name = data.name;
        product.length = data.length;
        product.image = result.Image;
        product.value = data.value;
        product.category = data.category;

        this.productService.Add(data).subscribe(result => console.log(result));
      });
  }
}