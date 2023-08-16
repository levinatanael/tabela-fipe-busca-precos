import { ComponentFixture, TestBed } from '@angular/core/testing';

import { PlacasListaComponent } from './placas-lista.component';

describe('PlacasListaComponent', () => {
  let component: PlacasListaComponent;
  let fixture: ComponentFixture<PlacasListaComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [PlacasListaComponent]
    });
    fixture = TestBed.createComponent(PlacasListaComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
