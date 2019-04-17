import { Component, OnInit } from '@angular/core';
import { registerModuleFactory } from '@angular/core/src/linker/ng_module_factory_loader';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent implements OnInit {
  registerMode = false;

  constructor() { }

  ngOnInit() {
  }

  registerToggle() {
    this.registerMode = !this.registerMode;
  }

}
