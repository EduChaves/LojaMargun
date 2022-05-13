import { Component, OnInit } from '@angular/core';
import { FormGroup } from '@angular/forms';
import { CategoryService } from 'src/app/Services/category.service';

@Component({
  selector: 'app-create-category',
  templateUrl: './create-category.component.html',
  styleUrls: ['./create-category.component.css']
})
export class CreateCategoryComponent implements OnInit {
  form: any;
  errors: string[] = [];
  constructor(private categoryService: CategoryService) { }

  ngOnInit(): void {
    this.form = new FormGroup({
      
    })
  }

}
